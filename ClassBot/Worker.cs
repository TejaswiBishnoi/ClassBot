using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassBot
{
    class Worker
    {
        public ChromeDriver driver = new ChromeDriver();
        public void Login(User user)
        {
            var UsrNam = driver.FindElement(By.Name("username"));
            var PasWrd = driver.FindElement(By.Name("password"));
            var LgnBtn = driver.FindElement(By.Id("loginbtn"));
            
            UsrNam.SendKeys(user.User_id);
            PasWrd.SendKeys(user.Password);
            LgnBtn.Click();
        }
    }
}
