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
            var WAD = new System.Diagnostics.Process();
            WAD.StartInfo.FileName = @"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe";
            WAD.StartInfo.RedirectStandardInput = true;
            WAD.Start();
            var id = Convert.ToInt32(Console.ReadLine());
            var Obj = new Worker();
            var user = new User();
            if (user.IsNull) Console.WriteLine("Error");
            //Login Test.
            //Code to reach login page.
            Obj.Login(user);            
            Obj.ReachCourse(id);
            Console.ReadLine();

        }
    }
}