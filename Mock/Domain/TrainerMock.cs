using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TrainerMock : ITrainer
    {
        public int id { get; }

        public TrainerMock(int id)
        {
            this.id = id;
        }
    }
}
