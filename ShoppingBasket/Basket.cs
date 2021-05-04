using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ShoppingBasket
{
    public class Basket : IBasket
    {
        private readonly Dictionary<string, int> _articles = new();
        private IInventory _inventory;

        // every customer gets her own basket => "new" implemented as constructor
        public Basket(IInventory inventory)
        {
            _inventory = inventory;
        }

        public void Scan(string articleId)
        {
            if (_articles.ContainsKey(articleId))
            {
                _articles[articleId]++;
            }
            else
            {
                _articles.Add(articleId, 1);
            }
        }

        public double Total()
        {
            double total = 0;

            foreach (var article in _articles)
            {
                double? articlePrice = null;

                // which discount should be applied if there are multiple to an article? should they interact?
                // -> take lowest price

                foreach (var discount in _inventory.Discounts)
                {
                    var articleDiscountPrice = discount.GetDiscountPrice(article.Value,
                        _inventory.inStock[article.Key]);
                    
                    if (discount.IsValid(article.Key, article.Value) &&
                        (!articlePrice.HasValue || articlePrice >= articleDiscountPrice))
                    {
                        articlePrice = articleDiscountPrice;
                    }
                }

                Debug.Assert(articlePrice != null, nameof(articlePrice) + " != null");
                total += articlePrice.Value;
            }


            return Math.Round(total, 2);
        }
    }
}