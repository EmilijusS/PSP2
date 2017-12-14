using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Domain.Financial.Abstractions;
using Domain.People.Abstractions;

namespace Facade.Financial.Abstractions
{
    public interface IBillCRUD
    {
        IBill CreateBill(int id, IClient client);
        IBill GetBill(int id);
        void DeleteBill(int id);
    }
}
