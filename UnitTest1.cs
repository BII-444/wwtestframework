using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ytestframework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            // allocate a browser drive
            IWebDriver my_driver = new ChromeDriver();
            // navigate to the Google homepage
            my_driver.Navigate().GoToUrl("https://www.google.com");
            // find search bar
            IWebElement searchbar = my_driver.FindElement(By.Name("q"));
            // send input
            searchbar.SendKeys("where is berlin");
            //wait and submit
            my_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            searchbar.Submit();

            // find h3 headers;
            IList<IWebElement> all_results = my_driver.FindElements(By.CssSelector(".LC20lb.MBeuO.DKV0Md"));

            my_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            foreach(IWebElement each_result in all_results)
            {
                if(!String.IsNullOrEmpty(each_result.Text))
                {
                    Console.WriteLine("Result: " + each_result.Text);
                }
                // Console.WriteLine("Title: " + each_result.Text);
                // System.out.println("Title : "+eachResult.getText()+", Link : "+eachResult.getAttribute("href"));
            }
            Assert.Pass();
        }
    }
}