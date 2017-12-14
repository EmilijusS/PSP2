using System;

namespace Domain.Inventory.Abstractions
{
    public interface IMachine
    {
        int Type { get; }
        DateTime PurchaseDate { get; } 
    }
}
