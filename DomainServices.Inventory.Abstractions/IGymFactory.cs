using Domain.Inventory.Abstractions;

namespace DomainServices.Inventory.Abstractions
{
    public interface IGymFactory
    {
        IGym GetGym(int id);
    }
}
