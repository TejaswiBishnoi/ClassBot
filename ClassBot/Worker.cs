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
        public ChromeDriver driver = new ChromeDriver(); // Creates a ChromeDriver session.
        const string baseUrl = @"https://lms.iitjammu.ac.in/course/view.php?id=";
        public void Login(User user, bool mid = false)
        {
            if (!mid) driver.Navigate().GoToUrl(@"https://lms.iitjammu.ac.in/login/index.php");
            // Finds Login fields and Buttons.
            var UsrNam = driver.FindElement(By.Name("username"));
            var PasWrd = driver.FindElement(By.Name("password"));
            var LgnBtn = driver.FindElement(By.Id("loginbtn"));
            
            //Enters the data int fields and then click the login button.
            UsrNam.SendKeys(user.User_id);
            PasWrd.SendKeys(user.Password);
            LgnBtn.Click();
            try
            {
                var Dan = driver.FindElement(By.ClassName("alert-danger"));
                Console.WriteLine("Incorrect Password");
            }
            catch(Exception e){
                
            }
            
            //if (driver.FindElement(By.ClassName("alert-danger")) != null) Console.WriteLine("Incorrect Password"); //Checks if Passwordis incorrect.
        }

        public void ReachCourse(int id)
        {
            driver.Navigate().GoToUrl(baseUrl + id.ToString());
            try
            {
                var Dan = driver.FindElement(By.ClassName("errorcode"));
                Console.WriteLine("Page Does not Exist");
                Console.Beep();
            }
            catch
            {

            }
            //if (driver.FindElement(By.ClassName("errorcode")) != null) Console.Beep();
        }
    }
}
