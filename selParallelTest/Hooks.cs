using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace selParallelTest
{
    public class Hooks : Base
    {
        public Hooks()
        {
            //initialize driver obj, from base clase, so we have just 1

            Driver = new FirefoxDriver(); //at this point there was no chrome option i think   
        }
    }
}
