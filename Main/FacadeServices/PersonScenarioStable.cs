﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Features.AttributeFilters;

namespace PSP2
{
    public class PersonScenarioStable : IPersonScenario
    {
        IClientFactory clientFactory;
        ITrainerFactory trainerFactory;
        IGetTrainerForClient getTrainerForClient;
        IClientRepository clientRepo;
        ITrainerRepository trainerRepo;
        ILogger logger;

        public PersonScenarioStable (
            IClientFactory clientFactory,
            ITrainerFactory trainerFactory,
            IGetTrainerForClient getTrainerForClient,
            IClientRepository clientRepo,
            ITrainerRepository trainerRepo,
            [KeyFilter("FacadeLogger")] ILogger logger)
        {
            this.clientFactory = clientFactory;
            this.trainerFactory = trainerFactory;
            this.getTrainerForClient = getTrainerForClient;
            this.clientRepo = clientRepo;
            this.trainerRepo = trainerRepo;
            this.logger = logger;
        }

        public void CreateClient(int id)
        {
            clientRepo.WriteClient(clientFactory.GetClient(id));
            logger.Log("Succesfully created new client.");
        }

        public void CreateTrainer(int id)
        {
            trainerRepo.WriteTrainer(trainerFactory.GetTrainer(id));
            logger.Log("Succesfully created new trainer.");
        }

        public ITrainer FindTrainerForClient(int clientId)
        {
            ITrainer trainer = getTrainerForClient.GetTrainer(clientRepo.GetClient(clientId), trainerRepo.GetAllTrainers());

            if (trainer == null)
                logger.Log($"Failed to find trainer for client {clientId}");
            else
                logger.Log($"Succesfully assigned trainer for client {clientId}");

            return trainer;
        }
    }
}
