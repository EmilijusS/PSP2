using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Financial.Abstractions;
using Domain.People.Abstractions;

namespace Domain.Financial
{
    public class Bill : IBill
    {
        public int Id { get; }
        public int Amount { get; }
        public int Type { get; }
        public IClient Client { get; }
    }
}
