using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class MainController
    {
        IMainViews mainViews;
        IPersonViews personViews;

        public MainController (IMainViews mainViews, IPersonViews personViews)
        {
            this.mainViews = mainViews;
            this.personViews = personViews;
        }

        public void mainMenu ()
        {
            mainViews.showMainMenu();
        }

        public void mainMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    personViews.showInsertClientId();
                    break;
                case 2:
                    personViews.showInsertTrainerId();
                    break;
                case 3:
                    personViews.showPairClientWithTrainer();
                    break;
                default:
                    mainViews.showMainMenu();
                    break;
            }
        }
    }
}
