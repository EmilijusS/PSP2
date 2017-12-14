using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Inventory.Abstractions;

namespace DomainServices.Inventory.Abstractions
{
    public interface IFindOldMachines
    {
        List<IMachine> GetOldMachines(List<IMachine> machines);
    }
}
