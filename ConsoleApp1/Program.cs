using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference for a webdriver specific to browser
            IWebDriver driver = new ChromeDriver();

            //pass the url
            driver.Url = "https://app.cloudqa.io/home/AutomationPracticeForm";

            var inputFields = driver.FindElements(By.TagName("input"));

            IWebElement firstInputElement = inputFields[0];
            firstInputElement.SendKeys("Diksha");

            IWebElement secondInputElement = inputFields[1];
            secondInputElement.SendKeys("Pandit" + Keys.Tab);

            IWebElement thirdInputElement = inputFields[3];
            System.Threading.Thread.Sleep(2000);
            thirdInputElement.Click();
            thirdInputElement.SendKeys(Keys.Tab);

        }
    }
}