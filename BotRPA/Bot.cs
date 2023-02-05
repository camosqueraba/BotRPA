using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotRPA
{
    class Bot
    {
        static void Main(string[] args)
        {
            const string URL = "https://github.com/";
            var driver = new ChromeDriver();
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            driver.Manage().Window.Maximize();


            var instrucciones = new Functionalities(driver, URL);

            var descripcion = instrucciones.GetDescription();

            jse.ExecuteScript($"alert('{descripcion}');");



            //driver.Quit();
        }
    }
}
