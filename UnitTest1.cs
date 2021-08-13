using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace wtestframework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestStringInput()
        {
            //USER INPUT


            // SITE NAVIGATION

            IWebDriver wdriver = new ChromeDriver();
            // navigate to site
            wdriver.Navigate().GoToUrl("https://www.google.com");
            // find search bar
            IWebElement searchbar = wdriver.FindElement(By.Name("q"));
            // send input
            searchbar.SendKeys("test");
            //wait and submit???
            wdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            searchbar.Submit();
            // searchbar.SendKeys("\t");

            Assert.Pass();
        }
        [OneTimeTearDown]
        public void EndProcess()
        {
            // wdriver.Close();
        }
    }
}