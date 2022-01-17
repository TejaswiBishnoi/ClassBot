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
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://lms.iitjammu.ac.in");
            Thread.Sleep(1000);
            var LogIn = driver.FindElement(By.CssSelector(@"a[href='https://lms.iitjammu.ac.in/login/index.php']"));
            LogIn.Click();
            Thread.Sleep(1000);
            var UsrNam = driver.FindElement(By.Name("username"));
            var PasWrd = driver.FindElement(By.Name("password"));
            var LgnBtn = driver.FindElement(By.Id("loginbtn"));

            UsrNam.SendKeys("2020UCS0084");
            PasWrd.SendKeys("Iam100%dehru");
            LgnBtn.Click();

            driver.Navigate().GoToUrl("https://lms.iitjammu.ac.in/course/view.php?id=324");
            Thread.Sleep(1000);

            var ZoomLink = driver.FindElement(By.XPath("//*[contains(text(), 'click here')]"));
            string link = ZoomLink.GetAttribute("href");
            driver.Navigate().GoToUrl(link);
            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}