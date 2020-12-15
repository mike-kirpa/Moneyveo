using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace GoogleSearch
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        ChromeOptions capability = new ChromeOptions();

        public void init()
        {
            capability.AddAdditionalCapability("os_version", "10", true);
            capability.AddAdditionalCapability("resolution", "1920x1080", true);
            capability.AddAdditionalCapability("browser", "Chrome", true);
            capability.AddAdditionalCapability("browser_version", "latest", true);
            capability.AddAdditionalCapability("os", "Windows", true);
            capability.AddAdditionalCapability("name", "BStack-[C_sharp] Sample Test", true); // test name
            capability.AddAdditionalCapability("build", "BStack Build Number 1", true); // CI/CD job or build name
            capability.AddAdditionalCapability("browserstack.user", "money30", true);
            capability.AddAdditionalCapability("browserstack.key", "yWwsVDP7A6QgrVjS4s2m", true);
            driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability);
            driver.Manage().Window.Maximize();
        }

        public void stop()
        {
            driver.Quit();
        }
    }
}