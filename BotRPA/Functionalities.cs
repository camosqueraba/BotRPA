using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotRPA
{
    public class Functionalities
    {
        private readonly ChromeDriver driver;
        private readonly string URL;

        public Functionalities(ChromeDriver driver, string URL)
        {
            this.driver = driver;
            this.URL = URL;
        }

        public string GetDescription()
        {
            driver.Navigate().GoToUrl(URL);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchBar = wait.Until(e => e.FindElement(By.Name("q")));


            searchBar = driver.FindElement(By.Name("q"));
            searchBar.Click();
            searchBar.SendKeys("selenium");
            searchBar.SendKeys(Keys.Enter);

            IWebElement result = wait.Until(e => e.FindElement(By.CssSelector(".repo-list-item:nth-child(4) a")));
            result.Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);



            var layoutSidebar = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => drv.FindElement(By.CssSelector(".Layout-sidebar")));


            var stringDescription = layoutSidebar.FindElement(By.CssSelector(".BorderGrid.BorderGrid--spacious p")).Text;



            Console.WriteLine("Elemento: {0}", stringDescription);



            return stringDescription;

        }
    }
}
