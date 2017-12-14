using Domain.Inventory.Abstractions;

namespace Facade.Inventory.Abstractions
{
    public interface IGymCRUD
    {
        IGym CreateGym(int id);
        IGym GetGym(int id);
        void DeleteGym(int id);
    }
}
