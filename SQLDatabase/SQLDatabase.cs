using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class SQLDatabase : IClientRepository, ITrainerRepository
    {
        private ILogger logger;
        private List<IClient> clients;
        private List<ITrainer> trainers;

        public SQLDatabase(ILogger logger)
        {
            this.logger = logger;
            clients = new List<IClient>();
            trainers = new List<ITrainer>();
        }

        public List<IClient> GetAllClients()
        {
            logger.Log("aaa");
            return new List<IClient>(clients);
        }

        public List<ITrainer> GetAllTrainers()
        {
            logger.Log("aaa");
            return new List<ITrainer>(trainers);
        }

        public IClient GetClient(int id)
        {
            logger.Log("aaa");
            foreach (IClient c in clients)
            {
                if (c.id == id)
                    return c;
            }

            return null;
        }

        public ITrainer GetTrainer(int id)
        {
            logger.Log("aaa");
            foreach (ITrainer t in trainers)
            {
                if (t.id == id)
                    return t;
            }

            return null;
        }

        public void WriteClient(IClient client)
        {
            logger.Log("aaa");
            clients.Add(client);
        }

        public void WriteTrainer(ITrainer trainer)
        {
            logger.Log("aaa");
            trainers.Add(trainer);
        }
    }
}
