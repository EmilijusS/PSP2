using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Features.AttributeFilters;

namespace PSP2
{
    public class PersonController
    {
        IMainViews mainViews;
        IPersonViews personViews;
        IPersonScenario personScenario;
        ILogger logger;

        public PersonController (IMainViews mainViews, IPersonViews personViews, IPersonScenario personScenario, [KeyFilter("ControllerLogger")] ILogger logger)
        {
            this.mainViews = mainViews;
            this.personViews = personViews;
            this.personScenario = personScenario;
            this.logger = logger;
        }

        public void CreateClient(int id)
        {
            personScenario.CreateClient(id);
            mainViews.showMainMenu();
            logger.Log("Main menu shown.");
        }

        public void CreateTrainer(int id)
        {
            personScenario.CreateTrainer(id);
            mainViews.showMainMenu();
            logger.Log("Main menu shown.");
        }

        public void FindTrainerForClient(int id)
        {
            ITrainer trainer = personScenario.FindTrainerForClient(id);

            if (trainer != null)
            {
                personViews.showPairClientWithTrainerSuccess(trainer.id);
                logger.Log("Client pairement with trainer success message shown");
            }
            else
            {
                personViews.showPairClientWithTrainerUnsuccess();
                logger.Log("CClient pairement with trainer failure message shown");

            }

            mainViews.showMainMenu();
        }
    }
}
