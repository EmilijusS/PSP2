using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace FacadeServices
{
    public interface IDatabase
    {
        Client GetClient(int id);
        void WriteClient(Client client);
        List<Client> GetAllClients();
        Trainer GetTrainer(int id);
        void WriteTrainer(Trainer trainer);
        List<Trainer> GetAllTrainers();
    }
}
