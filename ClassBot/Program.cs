using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var Obj = new Worker();
            var user = new User();
            //Login Test.
            //Code to reach login page.
            Obj.driver.Navigate().GoToUrl("https://lms.iitjammu.ac.in");
            Thread.Sleep(1000);
            var LogIn = Obj.driver.FindElement(By.CssSelector(@"a[href='https://lms.iitjammu.ac.in/login/index.php']"));
            LogIn.Click();
            Thread.Sleep(1000);
            //Login Function call.
            Obj.Login(user);
            Console.ReadKey();
            Obj.driver.Quit();
            GC.Collect();

        }
    }
}