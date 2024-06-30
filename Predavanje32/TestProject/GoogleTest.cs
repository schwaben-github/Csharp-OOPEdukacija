using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    [TestClass]
    public class GoogleTest
    {
        IWebDriver driver;

        //setup metoda
        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //otići na google.com
            driver.Navigate().GoToUrl("https://google.com");

            //pronađi gumb Odbij sve
            var buttonOdbij = driver.FindElement(By.Id("W0wltc"));

            //zatvori obavijest
            buttonOdbij.Click();

            //pronaći textbox element u koji upisujem pojam
            var textbox = driver.FindElement(By.Id("APjFqb"));

            //upisati pojam za pretragu
            textbox.SendKeys("Selenium");

            //pritisnuti enter
            textbox.Submit();

            /*//provjeriti naslov
            Assert.IsTrue(driver.Title.StartsWith("Selenium"));*/
        }

        //teardown metoda
        [TestCleanup]
        public void TestCleanup()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }
    }
}