using Domain.Inventory.Abstractions;

namespace DomainServices.Inventory.Abstractions
{
    public interface IMachineFactory
    {
        IMachine GetMachine(int id);
    }
}
