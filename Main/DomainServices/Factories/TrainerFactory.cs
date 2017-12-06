using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public class TrainerFactory : ITrainerFactory
    {
        public ITrainer GetTrainer(int id)
        {
            return new Trainer(id);
        }
    }
}
