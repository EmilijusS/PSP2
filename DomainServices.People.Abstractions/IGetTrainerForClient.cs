using System.Collections.Generic;
using Domain.People.Abstractions;

namespace DomainServices.People.Abstractions
{
    public interface IGetTrainerForClient
    {
        ITrainer GetTrainer(IClient client, List<ITrainer> trainers);
    }
}
