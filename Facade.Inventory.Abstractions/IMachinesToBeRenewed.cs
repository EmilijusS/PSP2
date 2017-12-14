using System.Collections.Generic;
using Domain.Inventory.Abstractions;

namespace Facade.Inventory.Abstractions
{
    public interface IMachinesToBeRenewed
    {
        List<IMachine> GetMachinesToBeRenewed();
    }
}
