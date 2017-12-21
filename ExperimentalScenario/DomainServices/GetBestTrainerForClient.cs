using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class GetBestTrainerForClient : IGetTrainerForClient
    {
        public ITrainer GetTrainer(IClient client, List<ITrainer> trainers)
        {
            if (trainers.Count > 0)
                return trainers[trainers.Count - 1];
            else
                return null;
        }
    }
}
