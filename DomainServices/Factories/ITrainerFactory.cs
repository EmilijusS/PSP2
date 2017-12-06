using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public interface ITrainerFactory
    {
        Trainer GetTrainer(int id);
    }
}
