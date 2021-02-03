using OpenQA.Selenium;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObject
{
    class ExamplePage
    {
        private readonly FileLocations _fileLocations;

        public ExamplePage()
        {
            driver = BaseTest.driver;
            _fileLocations = new FileLocations();
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@id='txtUsername']"));









        public void EnterUsername(string Username)
        {
            username.SendKeys(Username);
        }






    }
}
