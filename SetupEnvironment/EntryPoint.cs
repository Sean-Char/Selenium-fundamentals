using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver(); // create instance of driver

        driver.Navigate().GoToUrl("http://testing.todvachev.com");

        Thread.Sleep(3000); // keep page on for 3 seconds

        driver.Quit();
    }
}

