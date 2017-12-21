using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class NoSQLDatabase : IClientRepository, ITrainerRepository
    {
        private ILogger logger;
        private List<IClient> clients;
        private List<ITrainer> trainers;

        public NoSQLDatabase(ILogger logger)
        {
            this.logger = logger;
            clients = new List<IClient>();
            trainers = new List<ITrainer>();
        }

        public List<IClient> GetAllClients()
        {
            logger.Log("bbb");
            return new List<IClient>(clients);
        }

        public List<ITrainer> GetAllTrainers()
        {
            logger.Log("bbb");
            return new List<ITrainer>(trainers);
        }

        public IClient GetClient(int id)
        {
            logger.Log("bbb");
            foreach (IClient c in clients)
            {
                if (c.id == id)
                    return c;
            }

            return null;
        }

        public ITrainer GetTrainer(int id)
        {
            logger.Log("bbb");
            foreach (ITrainer t in trainers)
            {
                if (t.id == id)
                    return t;
            }

            return null;
        }

        public void WriteClient(IClient client)
        {
            logger.Log("bbb");
            clients.Add(client);
        }

        public void WriteTrainer(ITrainer trainer)
        {
            logger.Log("bbb");
            trainers.Add(trainer);
        }
    }
}
