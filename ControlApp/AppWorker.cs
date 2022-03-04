using System;
using System.Diagnostics;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
namespace AppControl
{
    public class AppWorker
    {
        public WindowsDriver<WindowsElement> wd;
        public  DesiredCapabilities appCapabilities = new DesiredCapabilities();
        public AppWorker()
        {
            appCapabilities.SetCapability("app", "Root");
            wd = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
        }
        public void ZoomChr()
        {            
            Thread.Sleep(5000);
            try
            {
                var f = wd.FindElementsByName("Open Zoom Meetings");
                for (int i = 0; i < f.Count; i++)
                {
                    if (f[i].GetAttribute("LocalizedControlType") == "button")
                    {
                        f[i].Click();
                        break;
                    }
                }
                f[1].Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
        public void ZoomSign()
        {
            Thread.Sleep(10000);
            try
            {
                var SignButton = wd.FindElementByName("Sign in to Join");
                SignButton.Click();
            }
            catch { };
        }


    }
}