using NUnit.Framework;
using AppControl;
namespace BotTest
{
    [TestFixture]
    public class Class1
    {
        AppWorker testappworker = new();
        [Test]
        public void func()
        {
            Assert.That(1 == 1);
        }
        [Test]
        public void ZoomChrTestRunningMeet()
        {
            testappworker.ZoomChr();
            Thread.Sleep(10000);
            try
            {
                testappworker.wd.FindElementByName("Zoom Meeting");
                Assert.That(true);
            }
            catch
            {
                Assert.That(false);
            }
        }        
        [Test]
        public void ZoomSignLogin()
        {
            testappworker.ZoomSign();
            Thread.Sleep(5000);
            var f = testappworker.WaitingForHost();
            Assert.IsTrue(f);
        }
        [Test]
        public void ZoomWaitingForHostTest()
        {
            var f = testappworker.WaitingForHost();
            Assert.IsTrue(f);
        }
        [Test]
        public void MeetingReadyJoined()
        {
            //Please make sure you've joined a meeting and currently in Waiting room or in Meeting
            var f = testappworker.MeetingReady();
            Assert.IsTrue(f);
        }
    }
}