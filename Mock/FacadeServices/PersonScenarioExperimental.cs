﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DomainServices;
using Autofac.Features.AttributeFilters;

namespace FacadeServices
{
    public class PersonScenarioExperimental : IPersonScenario
    {
        IClientFactory clientFactory;
        ITrainerFactory trainerFactory;
        IGetTrainerForClient getTrainerForClient;
        IDatabase database;
        ILogger logger;

        public PersonScenarioExperimental (
            IClientFactory clientFactory,
            ITrainerFactory trainerFactory,
            IGetTrainerForClient getTrainerForClient,
            IDatabase database,
            [KeyFilter("FacadeLogger")] ILogger logger)
        {
            this.clientFactory = clientFactory;
            this.trainerFactory = trainerFactory;
            this.getTrainerForClient = getTrainerForClient;
            this.database = database;
            this.logger = logger;
        }

        public void CreateClient(int id)
        {
            id *= 10;
            database.WriteClient(clientFactory.GetClient(id));
            logger.Log("Succesfully created new client.");

        }

        public void CreateTrainer(int id)
        {
            id *= 10;
            database.WriteTrainer(trainerFactory.GetTrainer(id));
            logger.Log("Succesfully created new trainer.");
        }

        public ITrainer FindTrainerForClient(int clientId)
        {
            clientId *= 10;

            IClient client = database.GetClient(clientId);
            ITrainer trainer = getTrainerForClient.GetTrainer(client, database.GetAllTrainers());

            if (trainer == null)
                logger.Log($"Failed to find trainer for client {clientId}");
            else
            {
                client.trainerId = trainer.id;
                logger.Log($"Succesfully assigned trainer for client {clientId}");
            }

            return trainer;
        }
    }
}
