using System.Collections.Generic;
using Domain.People.Abstractions;

namespace Facade.People.Abstractions
{
    interface ITrainerRepo
    {
        ITrainer GetTrainer(int id);
        void WriteTrainer(ITrainer trainer);
        List<ITrainer> GetAllTrainers();
    }
}
