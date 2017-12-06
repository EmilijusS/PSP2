using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public class GetBestTrainerForClient : IGetTrainerForClient
    {
        public Trainer GetTrainer(Client client, List<Trainer> trainers)
        {
            if (trainers.Count > 0)
                return trainers[trainers.Count - 1];
            else
                return null;
        }
    }
}
