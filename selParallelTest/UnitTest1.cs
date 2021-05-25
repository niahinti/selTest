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
        public class FirefoxTesting : Hooks // contract
        {

            [Test]
            public void FGoogleTest()
            {
                Driver.Navigate().GoToUrl("http://www.google.com");
                Driver.FindElement(By.Name("q")).SendKeys("selenium");
                Driver.FindElement(By.Name("btnG")).Click();
                Assert.That(Driver.PageSource.Contains("Selenium"),Is.EqualTo(true), "text selenium doesn't exist");
            }

        }

        [TestFixture]
        public class ChromeTesting : Hooks
        {

            [Test]
            public void CGoogleTest()
            {
                Driver.Navigate().GoToUrl("http://www.google.com");
                Driver.FindElement(By.Name("q")).SendKeys("hello world");
                Driver.FindElement(By.Name("btnG")).Click();
                Assert.That(Driver.PageSource.Contains("hello world"), Is.EqualTo(true), "text hello world doesn't exist");
            }

        }

    }
}