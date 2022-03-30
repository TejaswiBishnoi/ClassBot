using System;
using System.Diagnostics;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
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
                wd.FindElementByName("Sign in to Join").Click();
            }
            catch { };
        }

        public bool WaitingForHost()
        {
            try
            {
                var f = wd.FindElementByName("Please wait for the host to start this meeting.");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool MeetingReady()
        {
            try
            {
                var f = wd.FindElementByName("Zoom Meeting");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool LeaveMeeting()
        {
            try
            {
                wd.FindElementByName("Leave, Alt+Q").Click();
                wd.FindElementByName("Leave Meeting").Click();
                return true;
            }
            catch
            {
                
            }
            try
            {
                Actions act = new Actions(wd);
                act.SendKeys(OpenQA.Selenium.Keys.LeftAlt + OpenQA.Selenium.Keys.F4 + OpenQA.Selenium.Keys.LeftAlt).Perform();
                wd.FindElementByName("Leave Meeting").Click();
                return true;
            }
            catch { return false; }
        }
    }
}