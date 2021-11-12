using System.Collections.Generic;
using OpenQA.Selenium;
using Roman_Framework.Selenium;
using scripting_session.SwagLabs.Models;

namespace scripting_session.SwagLabs.Components
{
    public class InventoryItemWidget : AbstractWidget
    {
        private By AddToCartBtn = By.XPath(".//button[text()='Add to cart']");
        private By RemoveFromCartBtn = By.XPath(".//button[text()='Remove']");
        private By PriceLabel = By.ClassName("inventory_item_price");
        private By DescriptionParagraph = By.ClassName("inventory_item_desc");

        public string Price { get {return GetText(PriceLabel);}}
        public string Description { get {return GetText(DescriptionParagraph);}}
        private string ItemName {get;set;}

        public InventoryItemWidget(IWebDriver driver, InventoryItem item): base(driver)
        {
            ItemName = item.Name;
        }

        public override By _Locator => By.XPath("//div[text()='"+ItemName+"']/ancestor::div[@class='inventory_item']");

        public void AddItemToCart()
        {
            Click(AddToCartBtn);
        }

        public void RemoveItemFromCart()
        {
            Click(RemoveFromCartBtn);
        }


        public override bool WaitforDisplayed()
        {
            throw new System.NotImplementedException();
        }
    }
}