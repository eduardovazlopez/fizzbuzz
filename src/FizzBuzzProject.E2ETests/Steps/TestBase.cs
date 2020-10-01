using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzProject.E2ETests.Steps
{
    public class TestBase : IDisposable
    {
        protected IWebDriver driver;

        public TestBase()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public void Dispose()
        {
            driver.Quit();
            //driver.Dispose();
        }
    }
}
