using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class Client : IClient
    {
        public int id { get; }
        public int trainerId { get; set; }

        public Client(int id)
        {
            this.id = id;
        }
    }
}
