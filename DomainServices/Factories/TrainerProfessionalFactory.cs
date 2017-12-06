using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public class TrainerProfessionalFactory : ITrainerFactory
    {
        public Trainer GetTrainer(int id)
        {
            return new TrainerProfessional(id);
        }
    }
}
