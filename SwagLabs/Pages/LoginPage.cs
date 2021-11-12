using NUnit.Framework;
using OpenQA.Selenium;
using Roman_Framework.Selenium;
using scripting_session.SwagLabs.Models;

namespace scripting_session.SwagLabs.Pages
{
    public class LoginPage : AbstractPage
    {
        private By UsernameField = By.Id("user-name");
        private By PasswordField = By.Id("password");
        private By LoginBtn = By.Id("login-button");

        public string Username { get{return GetText(UsernameField);} set{SendKeys(UsernameField, value);} }
        
        

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        
        public override string _uri => "https://www.saucedemo.com/";

        public void Login(Credential credential)
        {
            NavigateTo();
            Assert.That(WaitforDisplayed(),"Failed to load username field");
            Username = credential.Username;
            SendKeys(PasswordField, credential.Password);
            Click(LoginBtn);
        }
      
        public override bool WaitforDisplayed()
        {
            return ValidateElement_Enabled_Displayed(UsernameField);
        }
    }
}