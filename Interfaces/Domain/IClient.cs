using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IClient
    {
        int id { get; }
        int trainerId { get; set; }
    }
}
