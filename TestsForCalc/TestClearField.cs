using NUnit.Framework;
using OpenQA.Selenium.Winium;

namespace TestClearField
{
    [TestFixture]
    class TestClearField
    {
        DesktopOptions options = new DesktopOptions();
        WiniumDriver app;


        [SetUp]
        public void OpenApp()
        {
            options.ApplicationPath = @"S:\Programing\Nadiia\projects\Calculator\Calculator\bin\Debug\Calculator.exe";
            app = new WiniumDriver(@"S:\Programing\Nadiia\projects\Calculator", options);
        }

        [Test]
        public void TestButtonC()
        {
            app.FindElementById("button3").Click();
            app.FindElementById("button07").Click();
            Assert.AreEqual(app.FindElementById("textBox1").Text, "57");
            app.FindElementById("button1").Click();
            Assert.AreEqual(app.FindElementById("textBox1").Text, "");

            app.Quit();
        }

        [Test]
        public void TestButtonCInEmptyField()
        {
            app.FindElementById("button1").Click();
            Assert.AreEqual(app.FindElementById("textBox1").Text, "");

            app.Quit();
        }

        [Test]
        public void TestButtonDeleteNum()
        {
            app.FindElementById("button8").Click();
            app.FindElementById("button04").Click();
            app.FindElementById("button7").Click();

            Assert.AreEqual(app.FindElementById("textBox1").Text, "2");
            app.Quit();
        }

        [Test]
        public void TestButtonDeleteThreeNum()
        {
            app.FindElementById("button04").Click();
            app.FindElementById("button13").Click();
            app.FindElementById("button12").Click();
            app.FindElementById("button8").Click();
            app.FindElementById("button7").Click();
            app.FindElementById("button7").Click();
            app.FindElementById("button7").Click();
            Assert.AreEqual(app.FindElementById("textBox1").Text, "4");
            app.Quit();
        }
    }
}
