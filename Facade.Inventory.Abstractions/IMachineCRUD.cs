using Domain.Inventory.Abstractions;

namespace Facade.Inventory.Abstractions
{
    public interface IMachineCRUD
    {
        IMachine CreateMachine(int id);
        IMachine GetMachine(int id);
        void DeleteMachine(int id);
    }
}
