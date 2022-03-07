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
        public static void Main()
        {

            var Obj = new Worker();
            var user = new User();
            if (user.IsNull) Console.WriteLine("Error");
            //Login Test.
            //Code to reach login page.
            Obj.Login(user);
            Obj.ReachCourse(324);
            Console.ReadLine();

        }
    }
}