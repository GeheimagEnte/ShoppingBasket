using System;

namespace ShoppingBasket
{
    public class Buy1Get1Free : IDiscount
    {
        private string validArticleId;
        
        public Buy1Get1Free(string articleId)
        {
            validArticleId = articleId;
        }
        
        public bool IsValid(string articleId, int count)
        {
            return articleId == validArticleId && count > 1;
        }

        public double GetDiscountPrice(int count, double price)
        {
            return Math.Ceiling(count / 2.0) * price;
        }
    }
}