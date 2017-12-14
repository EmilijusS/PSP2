using Domain.People.Abstractions;

namespace Domain.Financial.Abstractions
{
    public interface IBill
    {
        int Id { get; }
        int Amount { get; }
        int Type { get; }
        IClient Client { get; }
    }
}
