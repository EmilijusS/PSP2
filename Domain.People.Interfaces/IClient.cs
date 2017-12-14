namespace Domain.People.Abstractions
{
    public interface IClient
    {
        int Id { get; }
        int TrainerId { get; set; }
    }
}
