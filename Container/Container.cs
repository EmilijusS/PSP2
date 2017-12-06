using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DomainServices;
using FacadeServices;
using Integration;
using Repositories;
using UI;
using Autofac;

// Todo: 1. Visi servisai kelios realizacijos.
// Todo: 2. X variantas esybių (realClient ir fakeClient).
// Todo: 3. Abstrakcinių dalykų atskyrimas (pvz.: mock į atskirą, default kartu).
// Todo: 4. Pridėti domeninius servisus.
// Todo: 5. Clean Architecture & DIP.
// Todo: 6. Autofac sutvarkyti.
// Todo: 7. UML factory return type pakoreguoti.

namespace Container
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
            builder.RegisterType<Database>().As<IDatabase>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<ClientCheapFactory>().As<IClientFactory>();
            builder.RegisterType<TrainerSimpleFactory>().As<ITrainerFactory>();
            builder.RegisterType<GetLeastBusyTrainerForClient>().As<IGetTrainerForClient>();
            builder.RegisterType<PersonScenarioStable>().As<IPersonScenario>();
            builder.RegisterType<MainViews>().As<IMainViews>();
            builder.RegisterType<PersonViews>().As<IPersonViews>();
            builder.RegisterType<MainController>().AsSelf();
            builder.RegisterType<PersonController>().AsSelf();
        }

        void configuration2(ContainerBuilder builder)
        {
            builder.RegisterType<Database>().As<IDatabase>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<ClientPremiumFactory>().As<IClientFactory>();
            builder.RegisterType<TrainerProfessionalFactory>().As<ITrainerFactory>();
            builder.RegisterType<GetBestTrainerForClient>().As<IGetTrainerForClient>();
            builder.RegisterType<PersonScenarioExperimental>().As<IPersonScenario>();
            builder.RegisterType<MainViews>().As<IMainViews>();
            builder.RegisterType<PersonViews>().As<IPersonViews>();
            builder.RegisterType<MainController>().AsSelf();
            builder.RegisterType<PersonController>().AsSelf();
        }
    }
}
