using OpenQA.Selenium;
using scripting_session.SwagLabs.Pages;

namespace scripting_session.SwagLabs
{
    public class SwagLabsApplication
    {
        public LoginPage LoginPage { get; set; }
        public ProductsPage ProductPage { get; set; }
        
        public SwagLabsApplication(IWebDriver driver)
        {
            LoginPage = new LoginPage(driver);
            ProductPage = new ProductsPage(driver);
        }
    }
}