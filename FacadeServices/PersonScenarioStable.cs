using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DomainServices;

namespace FacadeServices
{
    public class PersonScenarioStable : IPersonScenario
    {
        IClientFactory clientFactory;
        ITrainerFactory trainerFactory;
        IGetTrainerForClient getTrainerForClient;
        IDatabase database;
        ILogger logger;

        public PersonScenarioStable (
            IClientFactory clientFactory,
            ITrainerFactory trainerFactory,
            IGetTrainerForClient getTrainerForClient,
            IDatabase database,
            ILogger logger)
        {
            this.clientFactory = clientFactory;
            this.trainerFactory = trainerFactory;
            this.getTrainerForClient = getTrainerForClient;
            this.database = database;
            this.logger = logger;
        }

        public void CreateClient(int id)
        {
            database.WriteClient(clientFactory.GetClient(id));
            logger.Log("Succesfully created new client.");
        }

        public void CreateTrainer(int id)
        {
            database.WriteTrainer(trainerFactory.GetTrainer(id));
            logger.Log("Succesfully created new trainer.");
        }

        public Trainer FindTrainerForClient(int clientId)
        {
            Trainer trainer = getTrainerForClient.GetTrainer(database.GetClient(clientId), database.GetAllTrainers());

            if (trainer == null)
                logger.Log($"Failed to find trainer for client {clientId}");
            else
                logger.Log($"Succesfully assigned trainer for client {clientId}");

            return trainer;
        }
    }
}
