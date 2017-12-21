using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public interface IGetTrainerForClient
    {
        ITrainer GetTrainer(IClient client, List<ITrainer> trainers);
    }
}
