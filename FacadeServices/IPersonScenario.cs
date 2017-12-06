﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace FacadeServices
{
    public interface IPersonScenario
    {
        void CreateClient(int id);
        void CreateTrainer(int id);
        Trainer FindTrainerForClient(int clientId);
    }
}