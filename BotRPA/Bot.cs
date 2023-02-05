using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotRPA
{
    ///<summary>
    ///Main class that starts the application
    ///</summary>
    ///<remarks>
    ///The driver, the url to visit, the configuration of the browser window are defined and the method that searches the repository is called..
    ///</remarks>
    class Bot
    {
       

        static void Main(string[] args)
        {

            const string URL = "https://github.com/";
            
            ChromeDriver driver = new ChromeDriver();
            
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            driver.Manage().Window.Maximize();


            var instrucciones = new Functionalities(driver, URL);

            var descripcion = instrucciones.GetDescription();

            jse.ExecuteScript($"alert('{descripcion}');");



            //driver.Quit();
        }
    }
}
