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
        private List<IClient> clients;
        private List<ITrainer> trainers;

        public Database()
        {
            clients = new List<IClient>();
            trainers = new List<ITrainer>();
        }

        public List<IClient> GetAllClients()
        {
            return new List<IClient>(clients);
        }

        public List<ITrainer> GetAllTrainers()
        {
            return new List<ITrainer>(trainers);
        }

        public IClient GetClient(int id)
        {
            foreach(IClient c in clients)
            {
                if (c.id == id)
                    return c;
            }

            return null;
        }

        public ITrainer GetTrainer(int id)
        {
            foreach (ITrainer t in trainers)
            {
                if (t.id == id)
                    return t;
            }

            return null;
        }

        public void WriteClient(IClient client)
        {
            clients.Add(client);
        }

        public void WriteTrainer(ITrainer trainer)
        {
            trainers.Add(trainer);
        }
    }
}
