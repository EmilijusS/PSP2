using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public interface ITrainerRepository
    {
        ITrainer GetTrainer(int id);
        void WriteTrainer(ITrainer trainer);
        List<ITrainer> GetAllTrainers();
    }
}
