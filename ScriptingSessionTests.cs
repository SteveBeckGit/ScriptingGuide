using System.Collections.Generic;
using NUnit.Framework;
using Roman_Framework;
using scripting_session.SwagLabs;
using scripting_session.SwagLabs.Models;

namespace scripting_session
{
    public class ScriptingSessionTests : RomanBase
    {
        [SetUp]
        public void TestSetup()
        {
        }

        [Test]
        public void LoginWithValidateCredentials()
        {
            //Given
            List<InventoryItem> AddItems = InventoryItem.GetItemsFromJson("4Products.json");
            List<InventoryItem> RemoveItems = InventoryItem.GetItemsFromJson("3Products.json");


            //when-then
            SwagLabsApplication application = new SwagLabsApplication(roman.Selenium.GetChromeDriver());
            application.LoginPage.Login(Credential.GetStandardUser());
            application.ProductPage.AddItemsToCart(AddItems);
            application.ProductPage.RemoveItemsFromCart(RemoveItems);
            application.ProductPage.StepPassedWithScreenshot("Hooray");
        }
    }
}