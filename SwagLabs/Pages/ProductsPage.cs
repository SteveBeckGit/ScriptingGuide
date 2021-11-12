using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using Roman_Framework.Selenium;
using scripting_session.SwagLabs.Components;
using scripting_session.SwagLabs.Models;

namespace scripting_session.SwagLabs.Pages
{
    public class ProductsPage : AbstractPage
    {
        private By InventoryContainer = By.Id("inventory_container");
        private By ShoppingCartBadge = By.ClassName("shopping_cart_badge");


        public ProductsPage(IWebDriver driver):base(driver)
        {
            
        }
        public override string _uri => throw new System.NotImplementedException();

        public void AddItemsToCart(List<InventoryItem> items)
        {
            foreach(InventoryItem item in items)
            {
                var inventory_item = new InventoryItemWidget(_driver, item);
                inventory_item.AddItemToCart();
            }

            //Will fail if 0 items were added
            Assert.That(GetText(ShoppingCartBadge).Equals(items.Count+""));
        }

        public void RemoveItemsFromCart(List<InventoryItem> items)
        {
            int startNumber = Int32.Parse(GetText(ShoppingCartBadge));

            foreach(InventoryItem item in items)
            {
                var inventory_item = new InventoryItemWidget(_driver, item);
                inventory_item.RemoveItemFromCart();
            }

            int endNumber = Convert.ToInt32(GetText(ShoppingCartBadge));
            Assert.That((startNumber-endNumber) == items.Count);
        }


        public override bool WaitforDisplayed()
        {
            throw new System.NotImplementedException();
        }
    }
}