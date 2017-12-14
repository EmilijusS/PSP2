using System.Collections.Generic;
using Domain.People.Abstractions;

namespace Facade.People.Abstractions
{
    interface IClientRepo
    {
        IClient GetClient(int id);
        void WriteClient(IClient client);
        List<IClient> GetAllClients();
    }
}
