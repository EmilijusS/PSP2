using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class Trainer : ITrainer
    {
        public int id { get; }

        public Trainer(int id)
        {
            this.id = id;
        }
    }
}
