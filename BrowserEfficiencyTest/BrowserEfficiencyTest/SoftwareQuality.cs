using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BrowserEfficiencyTest
{
    internal class SoftwareQuality : Scenario
    {
        internal SoftwareQuality()
        {
            Name = "SoftwareQuality";
            DefaultDuration = 10;
        }

        public override void Run(RemoteWebDriver driver, string browser, CredentialManager credentialManager, ResponsivenessTimer timer)
        {
            driver.Navigate().GoToUrl("https://www.muni.cz");

            var searchBox = driver.FindElementById("search");
            
            searchBox.SendKeys("Software Quality" + Keys.Enter);

            driver.FindElementsByClassName("gs-title").First().Click();
        }
    }
}
