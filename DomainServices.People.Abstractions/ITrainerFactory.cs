using Domain.People.Abstractions;

namespace DomainServices.People.Abstractions
{
    public interface ITrainerFactory
    {
        ITrainer GetTrainer(int id);
    }
}
