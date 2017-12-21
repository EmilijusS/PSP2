using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public interface IClientRepository
    {
        IClient GetClient(int id);
        void WriteClient(IClient client);
        List<IClient> GetAllClients();
    }
}
