using System;

namespace ShoppingBasket
{
    // Create interface for DI
    public interface IBasket
    {
        // a new article can be added to the basket
        public void Scan(string articleId);

        // the customer can query the total amount any time
        public double Total();
    }
}