using Domain.People.Abstractions;

namespace Facade.People.Abstractions
{
    public interface IClientCRUD
    {
        IClient CreateClient(int id);
        IClient GetClient(int id);
        void DeleteClient(int id);
    }
}
