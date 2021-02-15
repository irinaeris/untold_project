using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UntoldProject.PageObjects
{
    partial class HomePage
    {
        public IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement menuButton => _driver.FindElement(By.XPath("//*[@id='react-burger-menu-btn']"));
        private IWebElement homeButton => _driver.FindElement(By.XPath("//*[@class='styles-module--menuItem--2roYz']"));
        public IWebElement menuList => _driver.FindElement(By.XPath("//*[@class='bm-menu-wrap']"));


    }
}
