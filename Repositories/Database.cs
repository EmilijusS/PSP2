using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeServices;
using Domain;

namespace Repositories
{
    public class Database : IDatabase
    {
        private List<Client> clients;
        private List<Trainer> trainers;

        public Database()
        {
            clients = new List<Client>();
            trainers = new List<Trainer>();
        }

        public List<Client> GetAllClients()
        {
            return new List<Client>(clients);
        }

        public List<Trainer> GetAllTrainers()
        {
            return new List<Trainer>(trainers);
        }

        public Client GetClient(int id)
        {
            foreach(Client c in clients)
            {
                if (c.id == id)
                    return c;
            }

            return null;
        }

        public Trainer GetTrainer(int id)
        {
            foreach (Trainer t in trainers)
            {
                if (t.id == id)
                    return t;
            }

            return null;
        }

        public void WriteClient(Client client)
        {
            clients.Add(client);
        }

        public void WriteTrainer(Trainer trainer)
        {
            trainers.Add(trainer);
        }
    }
}
