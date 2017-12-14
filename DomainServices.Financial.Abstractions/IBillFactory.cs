using Domain.Financial.Abstractions;

namespace DomainServices.Financial.Abstractions
{
    public interface IBillFactory
    {
        IBill GetBill(int id);
    }
}
