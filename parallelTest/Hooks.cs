using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace selParallelTest
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }

    [TestFixture]
    public class Hooks : Base
    {
        private const string ChromeDriverDirectory = "C:\\Selenium";
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            //initialize driver obj, from base clase, so we have just 1
            _browserType = browser;
        }

        [SetUp]
        public void initialize()
        {
            ChooseDriverInstance(_browserType);
        }


        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Driver = new ChromeDriver(ChromeDriverDirectory);
            else if (browserType == BrowserType.Firefox)
                Driver = new FirefoxDriver();
        }

    }
}
