using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public interface IGetTrainerForClient
    {
        Trainer GetTrainer(Client client, List<Trainer> trainers);
    }
}
