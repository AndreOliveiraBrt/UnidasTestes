using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnidasTestes.Base
{
    public class PageFactory
    {
        public static IWebDriver driver;
        public static IWebDriver GetWebDriver()
        {
            //Configurações ChromeDriver
            ChromeOptions cap_chrome = new ChromeOptions();
            cap_chrome.AddArguments("--whitelisted-ips");
            cap_chrome.AddArguments("--disable-gpu");
            cap_chrome.AddArguments("--no-sandbox");
            cap_chrome.AddArgument("--disable-extensions");
            cap_chrome.AddArguments("--start-maximized");

            var timeOutTime = TimeSpan.FromMinutes(10);
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), cap_chrome, timeOutTime);

            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(120));
            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(120));
            return driver;
        }
        public static void KillDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
