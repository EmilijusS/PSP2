using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public interface IPersonScenario
    {
        void CreateClient(int id);
        void CreateTrainer(int id);
        ITrainer FindTrainerForClient(int clientId);
    }
}
