using Domain.People.Abstractions;

namespace DomainServices.People.Abstractions
{
    public interface IClientFactory
    {
        IClient GetClient(int id);
    }
}
