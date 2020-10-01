using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzProject.E2ETests.Pages
{
    public class FizzBuzzPage
    {
        private IWebDriver _driver;
        public IList<IWebElement> fizzBuzzResults => _driver.FindElements(By.Name("FBli"));
        public IWebElement runTestButton => _driver.FindElement(By.Id("RunTestButton"));

        public FizzBuzzPage(IWebDriver driver) => _driver = driver;
        public void GotoFizzBuzzPage() => _driver.Url = "https://localhost:5001/";
    }
}
