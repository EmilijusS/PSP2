using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Inventory.Abstractions;

namespace Domain.Inventory
{
    public class Gym : IGym
    {
        public string Address { get; }
        public int Length { get; }
        public int Width { get; }
        public int Id { get; }
    }
}
