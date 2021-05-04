using System.Collections.Generic;

namespace ShoppingBasket
{
    public class Inventory : IInventory
    {
        private Dictionary<string, double> _inStock = new()
        {
            {"A0001", 12.99},
            {"A0002", 3.99}
        };

        private List<IDiscount> _discounts = new() {new NoDiscount()};
        public Dictionary<string, double> inStock => _inStock;
        public List<IDiscount> Discounts => _discounts;
    }
}