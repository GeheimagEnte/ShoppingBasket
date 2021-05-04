namespace ShoppingBasket
{
    
    // Discounts are hardcoded => need codechange for new discounts :-(
    public interface IDiscount
    {
        public bool IsValid(string articleId, int count);

        public double GetDiscountPrice(int count, double price);
    }
}