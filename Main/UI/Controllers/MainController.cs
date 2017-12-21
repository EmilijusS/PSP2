using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Features.AttributeFilters;

namespace PSP2
{
    public class MainController
    {
        IMainViews mainViews;
        IPersonViews personViews;
        ILogger logger;

        public MainController (IMainViews mainViews, IPersonViews personViews, [KeyFilter("ControllerLogger")] ILogger logger)
        {
            this.mainViews = mainViews;
            this.personViews = personViews;
            this.logger = logger;
        }

        public void mainMenu ()
        {
            mainViews.showMainMenu();
            logger.Log("Main menu shown.");
        }

        public void mainMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    personViews.showInsertClientId();
                    logger.Log("Client id insertion menu shown.");
                    break;
                case 2:
                    personViews.showInsertTrainerId();
                    logger.Log("Trainer id insertion menu shown.");
                    break;
                case 3:
                    personViews.showPairClientWithTrainer();
                    logger.Log("Client pairement with trainer menu shown.");
                    break;
                default:
                    mainViews.showMainMenu();
                    logger.Log("Main menu shown.");
                    break;
            }
        }
    }
}
