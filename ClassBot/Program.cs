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

            Obj.driver.Navigate().GoToUrl("https://lms.iitjammu.ac.in");
            Thread.Sleep(1000);
            var LogIn = Obj.driver.FindElement(By.CssSelector(@"a[href='https://lms.iitjammu.ac.in/login/index.php']"));
            LogIn.Click();
            Thread.Sleep(1000);
            Obj.Login();

            Obj.driver.Navigate().GoToUrl("https://lms.iitjammu.ac.in/course/view.php?id=324");
            Thread.Sleep(1000);

            var ZoomLink = Obj.driver.FindElement(By.XPath("//*[contains(text(), 'click here')]"));
            string link = ZoomLink.GetAttribute("href");
            Obj.driver.Navigate().GoToUrl(link);
            Thread.Sleep(5000);
            Obj.driver.Quit();
        }
    }
}