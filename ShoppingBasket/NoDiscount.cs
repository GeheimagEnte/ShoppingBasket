namespace ShoppingBasket
{
    class NoDiscount : IDiscount
    {
        public bool IsValid(string articleId, int count)
        {
            return true;
        }

        public double GetDiscountPrice(int count, double price)
        {
            return count * price;
        }
    }
}