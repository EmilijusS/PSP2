using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Autofac.Features.AttributeFilters;

namespace PSP2
{
    public class Container
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            Console.WriteLine("What configuration (1, 2)?");

            var conf = Console.ReadLine()[0] - '0';

            if (conf == 1)
                new Container().configuration1(builder);
            else
                new Container().configuration2(builder);

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var main = scope.Resolve<MainController>();
                var person = scope.Resolve<PersonController>();

                main.mainMenu();

                while(true)
                {
                    var input1 = Console.ReadLine()[0] - '0';

                    main.mainMenuChoice(input1);

                    if (input1 < 1 && input1 > 3)
                        continue;

                    var input2 = Console.ReadLine()[0] - '0';

                    switch(input1)
                    {
                        case 1:
                            person.CreateClient(input2);
                            break;
                        case 2:
                            person.CreateTrainer(input2);
                            break;
                        case 3:
                            person.FindTrainerForClient(input2);
                            break;
                    }
                }
            }
        }

        void configuration1(ContainerBuilder builder)
        {
            builder.RegisterType<SQLDatabase>().As<ITrainerRepository>();
            builder.RegisterType<SQLDatabase>().As<IClientRepository>();
            builder.RegisterType<FileLogger>().Keyed<ILogger>("FacadeLogger");
            builder.RegisterType<HttpLogger>().Keyed<ILogger>("ControllerLogger");
            builder.RegisterType<ClientFactory>().As<IClientFactory>();
            builder.RegisterType<TrainerFactory>().As<ITrainerFactory>();
            builder.RegisterType<GetLeastBusyTrainerForClient>().As<IGetTrainerForClient>();
            builder.RegisterType<PersonScenarioStable>().As<IPersonScenario>().WithAttributeFiltering();
            builder.RegisterType<MainViews>().As<IMainViews>();
            builder.RegisterType<PersonViews>().As<IPersonViews>();
            builder.RegisterType<MainController>().AsSelf().WithAttributeFiltering();
            builder.RegisterType<PersonController>().AsSelf().WithAttributeFiltering();
        }

        void configuration2(ContainerBuilder builder)
        {
            builder.RegisterType<FileLogger>().Keyed<ILogger>("SQLDatabaseLogger");
            builder.RegisterType<HttpLogger>().Keyed<ILogger>("NoSQLDatabaseLogger");
            builder.RegisterType<SQLDatabase>().As<ITrainerRepository>().WithParameter(ResolvedParameter.ForKeyed<ILogger>("SQLDatabaseLogger"));
            builder.RegisterType<NoSQLDatabase>().As<IClientRepository>().WithParameter(ResolvedParameter.ForKeyed<ILogger>("NoSQLDatabaseLogger"));

            builder.RegisterType<FileLogger>().Keyed<ILogger>("FacadeLogger");
            builder.RegisterType<HttpLogger>().Keyed<ILogger>("ControllerLogger");
            builder.RegisterType<ClientMockFactory>().As<IClientFactory>();
            builder.RegisterType<TrainerMockFactory>().As<ITrainerFactory>();
            builder.RegisterType<GetBestTrainerForClient>().As<IGetTrainerForClient>();
            builder.RegisterType<PersonScenarioExperimental>().As<IPersonScenario>().WithAttributeFiltering();
            builder.RegisterType<MainViews>().As<IMainViews>();
            builder.RegisterType<PersonViews>().As<IPersonViews>();
            builder.RegisterType<MainController>().AsSelf().WithAttributeFiltering();
            builder.RegisterType<PersonController>().AsSelf().WithAttributeFiltering();
        }
    }
}
