using Domain.People.Abstractions;

namespace Domain.People
{
    public class Trainer : ITrainer
    {
        public int Id { get; }

        public Trainer(int id)
        {
            this.Id = id;
        }
    }
}
