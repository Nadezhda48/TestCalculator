using NUnit.Framework;
using OpenQA.Selenium.Winium;

namespace TestClearField
{
    [TestFixture]
    class TestSign
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
        public void TestMultySign()
        {
            // "-"
            app.FindElementById("button10").Click();
            app.FindElementById("button10").Click();
            app.FindElementById("button10").Click();
            
            app.FindElementById("button8").Click();
            app.FindElementById("button8").Click();
            // ","
            app.FindElementById("button12").Click();
            app.FindElementById("button12").Click();

            app.FindElementById("button14").Click();




            Assert.AreEqual(app.FindElementById("textBox1").Text, "-22,3");
            app.Quit();
        }

        [Test]
        public void TestChangeSign()
        {

            app.FindElementById("button18").Click();
            app.FindElementById("button8").Click();
            // ","
            app.FindElementById("button12").Click();
            app.FindElementById("button14").Click();

            app.FindElementById("button6").Click();

            Assert.AreEqual(app.FindElementById("textBox1").Text, "-62,3");

            app.FindElementById("button6").Click();

           Assert.AreEqual(app.FindElementById("textBox1").Text, "62,3");
            app.Quit();
        }

    }
}
