using System.Collections.Generic;

namespace ShoppingBasket
{
    public interface IInventory
    {
        public Dictionary<string, double> inStock { get;  }
        public List<IDiscount> Discounts { get;  }
    }
}