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
        IClient GetClient(int id);
        void WriteClient(IClient client);
        List<IClient> GetAllClients();
        ITrainer GetTrainer(int id);
        void WriteTrainer(ITrainer trainer);
        List<ITrainer> GetAllTrainers();
    }
}
