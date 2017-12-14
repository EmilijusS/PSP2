using Domain.People.Abstractions;

namespace Domain.People
{
    public class Client : IClient
    {
        public int Id { get; }
        public int TrainerId { get; set; }

        public Client(int id)
        {
            this.Id = id;
        }
    }
}
