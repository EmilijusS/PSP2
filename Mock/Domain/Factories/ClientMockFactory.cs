using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class ClientMockFactory : IClientFactory
    {
        public IClient GetClient(int id)
        {
            return new ClientMock(id);
        }
    }
}
