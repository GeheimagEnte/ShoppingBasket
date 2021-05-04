namespace ShoppingBasket
{
    public class TenPercent : IDiscount 
    {        
        private string validArticleId;
        
        public TenPercent(string articleId)
        {
            validArticleId = articleId;
        }

        public bool IsValid(string articleId, int count)
        {
            return articleId == validArticleId;
        }

        public double GetDiscountPrice(int count, double price)
        {
            return count * price * 0.9;
        }
    }
}