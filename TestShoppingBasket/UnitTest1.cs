using System;
using ShoppingBasket;
using Xunit;

namespace TestShoppingBasket
{
    public class UnitTest1
    {
        [Fact]
        public void Buy1Get1FreeTest()
        {
            var inventory = new Inventory();
            inventory.Discounts.Add( new Buy1Get1Free("A0002"));
            Basket basket = new Basket(inventory);
            basket.Scan("A0002");
            basket.Scan("A0001");
            basket.Scan("A0002");
            Assert.Equal(16.98, basket.Total());
        }
        
        [Fact]
        public void TenPercentTest()
        {
            var inventory = new Inventory();
            inventory.Discounts.Add( new TenPercent("A0001"));
            Basket basket = new Basket(inventory);
            basket.Scan("A0002");
            basket.Scan("A0001");
            basket.Scan("A0002");
            Assert.Equal(19.67, basket.Total());
        }
    }
}