using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public class TrainerMockFactory : ITrainerFactory
    {
        public ITrainer GetTrainer(int id)
        {
            return new TrainerMock(id);
        }
    }
}
