using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Financial.Abstractions;

namespace DomainServices.Financial.Abstractions
{
    public interface ICalculateBillAmount
    {
        IBill GetBillAmount(IBill bill);
    }
}
