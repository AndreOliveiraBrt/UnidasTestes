using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.IO;

namespace UnidasTestes.Base
{
    public class BaseTeste : PageFactory
    {
        public TestContext TestContext { get; set; }
        public BaseTeste() { }

        [TestInitialize]
        public void Inicializa()
        {
            PageFactory.GetWebDriver().Navigate().GoToUrl("http://www.unidas.com.br");
        }

        [TestCleanup]
        public void Finaliza()
        {
            if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {

                string pastaPrints = @"../../Prints/";
                if (!Directory.Exists(pastaPrints))
                {
                    _ = Directory.CreateDirectory(pastaPrints);
                    ITakesScreenshot save = driver as ITakesScreenshot;
                    save.GetScreenshot().SaveAsFile(@"../../Prints/" + TestContext.TestName + ".png", ScreenshotImageFormat.Png);
                }
                else
                {
                    ITakesScreenshot save = driver as ITakesScreenshot;
                    save.GetScreenshot().SaveAsFile(@"../../Prints/" + TestContext.TestName + ".png", ScreenshotImageFormat.Png);
                }
            }

            PageFactory.KillDriver();
        }

    }
}
