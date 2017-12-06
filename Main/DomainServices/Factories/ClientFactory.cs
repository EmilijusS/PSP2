using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public class ClientFactory : IClientFactory
    {
        public IClient GetClient(int id)
        {
            return new Client(id);
        }
    }
}
