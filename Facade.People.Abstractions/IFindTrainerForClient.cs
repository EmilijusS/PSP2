using Domain.People.Abstractions;

namespace Facade.People.Abstractions
{
    public interface IFindTrainerForClient
    {
        ITrainer FindTrainerForClient(int clientId);
    }
}
