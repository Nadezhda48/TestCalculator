using NUnit.Framework;
using OpenQA.Selenium.Winium;

namespace TestClearField
{
    [TestFixture]
    public class TestMathematicalOperations
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
        public void TestMinus()
        {
            app.FindElementById("button8").Click();
            app.FindElementById("button3").Click();
            app.FindElementById("button10").Click();
            app.FindElementById("button8").Click();
            app.FindElementById("button11").Click();                      

            StringAssert.Contains(app.FindElementById("textBox1").Text, "23");
            app.Quit();
        }

        [Test]
        public void TestPlus()
        {
            app.FindElementById("button4").Click();
            app.FindElementById("button9").Click();
            app.FindElementById("button2").Click();
            app.FindElementById("button13").Click();
            app.FindElementById("button11").Click();

            StringAssert.Contains(app.FindElementById("textBox1").Text, "18");
            app.Quit();
        }

        [Test]
        public void TestDivision()
        {

            app.FindElementById("button4").Click();
            app.FindElementById("button14").Click();
            // "/"
            app.FindElementById("button5").Click();

            app.FindElementById("button8").Click();
            app.FindElementById("button13").Click();
            //=
            app.FindElementById("button11").Click();

            StringAssert.Contains(app.FindElementById("textBox1").Text, "4,15");
            app.Quit();
        }

        [Test]
        public void TestDivisionByZero()
        {
            app.FindElementById("button4").Click();
            app.FindElementById("button14").Click();
            // "/"
            app.FindElementById("button5").Click();

            app.FindElementById("button13").Click();


            //=
            app.FindElementById("button11").Click();
            StringAssert.Contains(app.FindElementById("textBox1").Text, "0");
            app.Quit();
        }

        [Test]
        public void TestMultiplication()
        {
            app.FindElementById("button4").Click();
            app.FindElementById("button12").Click();

            app.FindElementById("button14").Click();
            // "*"
            app.FindElementById("button15").Click();

            app.FindElementById("button13").Click();


            //=
            app.FindElementById("button11").Click();
            StringAssert.Contains(app.FindElementById("textBox1").Text, "0");
            app.Quit();

        }
    }
}
