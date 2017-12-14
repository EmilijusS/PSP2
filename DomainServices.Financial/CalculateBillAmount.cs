using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Financial.Abstractions;
using DomainServices.Financial.Abstractions;

namespace DomainServices.Financial
{
    class CalculateBillAmount : ICalculateBillAmount
    {
        public IBill GetBillAmount(IBill bill)
        {
            return bill;
        }
    }
}
