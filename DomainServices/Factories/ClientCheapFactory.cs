using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DomainServices
{
    public class ClientCheapFactory : IClientFactory
    {
        public Client GetClient(int id)
        {
            return new ClientCheap(id);
        }
    }
}
