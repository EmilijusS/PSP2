using Domain.People.Abstractions;

namespace Facade.People.Abstractions
{
    public interface ITrainerCRUD
    {
        ITrainer CreateTrainer(int id);
        ITrainer GetTrainer(int id);
        void DeleteClient(int id);
    }
}
