namespace Domain.Inventory.Abstractions
{
    public interface IGym
    {
        string Address { get; }
        int Length { get; }
        int Width { get; }
        int Id { get; }
    }
}
