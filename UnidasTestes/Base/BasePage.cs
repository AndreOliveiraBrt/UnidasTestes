using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;
using static UnidasTestes.Base.PageFactory;

namespace UnidasTestes.Base
{
    public class BasePage
    {

        public void Escrever(By by, string texto)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            driver.FindElement(by).SendKeys(texto);
        }
        public void EscreverID(string id_campo, string texto)
        {
            Escrever(By.Id(id_campo), texto);
        }
        public void LimparTexto(By by)
        {
            driver.FindElement(by).Clear();
        }

        public void Ckeckbox(string xpath)
        {
            IWebElement radioBtn1 = driver.FindElement(By.XPath(xpath));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", radioBtn1);
        }
        public static void EsperaElementoVisivel(string valor, int timeout = 90)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ElementIsVisible(By.XPath(valor)));
        }
        public static Boolean VerificarElemento(string xpath)
        {
            try
            {
                EsperaElementoVisivel(xpath, 5);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
