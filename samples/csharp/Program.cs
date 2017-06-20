using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static System.Console;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver(new ChromeOptions { DebuggerAddress = "localhost:9222" })
            {
                Url = "http://www.google.com/ncr"
            };
            try
            {
                driver.Navigate();
                driver.FindElement(By.Name("q")).SendKeys("webdriver dotnet");
                driver.FindElement(By.Name("btnG")).Click();
                var found = new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(d => d.Title == "webdriver dotnet - Google Search");
                WriteLine($"Found: {found}");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                driver.Dispose();
            }
        }
    }
}