using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Financial;
using Domain.Financial.Abstractions;
using DomainServices.Financial.Abstractions;

namespace DomainServices.Financial
{
    class BillFactory : IBillFactory
    {
        public IBill GetBill(int id)
        {
            return new Bill();
        }
    }
}
