using FizzBuzzProject.E2ETests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzProject.E2ETests.Steps
{
    public class FizzBuzzSteps : TestBase
    {
        private FizzBuzzPage fizzBuzzPage;

        public FizzBuzzSteps() => fizzBuzzPage = new FizzBuzzPage(driver);

        [Fact]
        public void CheckFizzBuzz()
        {
            fizzBuzzPage.GotoFizzBuzzPage();
            fizzBuzzPage.runTestButton.Click();
            Assert.True(FizzBuzzTestCheck(fizzBuzzPage.fizzBuzzResults));
        }

        private bool FizzBuzzTestCheck(IList<IWebElement> elements)
        {
            bool result = true;
            for (int i = 1; i <= 100; i++)
            {
                if (!result)
                    break;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = elements[i - 1].Text == "FizzBuzz";
                    continue;
                }
                if (i % 3 == 0)
                {
                    result = elements[i - 1].Text == "Fizz";
                    continue;
                }
                if (i % 5 == 0)
                {
                    result = elements[i - 1].Text == "Buzz";
                    continue;
                }

                
            }
            return result;
        }
    }
}
