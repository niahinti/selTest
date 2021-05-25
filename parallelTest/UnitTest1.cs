using NUnit.Framework;
using OpenQA.Selenium;
using selParallelTest;
using System;

namespace Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestFixture]
        [Parallelizable]
        public class FirefoxTesting : Hooks // contract
        {
            public FirefoxTesting() : base(BrowserType.Firefox)
            {

            }

            [Test]
            public void FGoogleTest()
            {
                Driver.Navigate().GoToUrl("http://www.google.com");
                Driver.FindElement(By.Name("q")).SendKeys("selenium");
                Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(10000);
                //Driver.FindElement(By.Name("btnK")).Click();
                Assert.That(Driver.PageSource.Contains("Selenium"),Is.EqualTo(true), "text selenium doesn't exist");
            }
        }

        [TestFixture]
        [Parallelizable]
        public class ChromeTesting : Hooks
        {
            public ChromeTesting() : base(BrowserType.Chrome)
            {
            }

            [Test]
            public void CGoogleTest()
            {
                Driver.Navigate().GoToUrl("http://www.google.com");
                Driver.FindElement(By.Name("q")).SendKeys("hello world");
                Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                Assert.That(Driver.PageSource.Contains("hello world"), Is.EqualTo(true), "text hello world doesn't exist");
            }
            //Message: System.InvalidOperationException : session not created: This version of ChromeDriver only supports Chrome version 85 (SessionNotCreated)
        }

        [TearDown]
        public void CleanUp()
        {
            //Driver.Close();
            Console.WriteLine("cerre browser");
        }

    }
}