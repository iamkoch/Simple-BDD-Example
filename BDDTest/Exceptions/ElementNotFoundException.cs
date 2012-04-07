using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace BDDTest.Exceptions
{
    public class ElementNotFoundException : Exception
    {
        private readonly By by;

        public ElementNotFoundException(By by)
        {
            this.by = by;
        }

        public override string Message
        {
            get { return string.Format("Unable to find element {0}", this.by); }
        }
    }
}
