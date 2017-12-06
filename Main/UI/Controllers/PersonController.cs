using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeServices;
using Domain;

namespace UI
{
    public class PersonController
    {
        IMainViews mainViews;
        IPersonViews personViews;
        IPersonScenario personScenario;

        public PersonController (IMainViews mainViews, IPersonViews personViews, IPersonScenario personScenario)
        {
            this.mainViews = mainViews;
            this.personViews = personViews;
            this.personScenario = personScenario;
        }

        public void CreateClient(int id)
        {
            personScenario.CreateClient(id);
            mainViews.showMainMenu();
        }

        public void CreateTrainer(int id)
        {
            personScenario.CreateTrainer(id);
            mainViews.showMainMenu();
        }

        public void FindTrainerForClient(int id)
        {
            ITrainer trainer = personScenario.FindTrainerForClient(id);

            if (trainer != null)
                personViews.showPairClientWithTrainerSuccess(trainer.id);
            else
                personViews.showPairClientWithTrainerUnsuccess();

            mainViews.showMainMenu();
        }
    }
}
