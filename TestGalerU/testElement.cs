using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace automation
{
    internal class testElement : baseTest
    {
        public override IWebElement findClass(string ByString)
        {
            return driver.FindElement(By.ClassName(ByString));
            //return driver.FindElement(By.CssSelector("button[class='btn btn-primary w-100']"));
        }

        public override IWebElement findId(string ByString)
        {
            return driver.FindElement(By.Id(ByString));
        }

        public override IWebElement findPartialText(string ByString)
        {
            //var Elements = driver.FindElements(By.PartialLinkText("Continue"));
            return driver.FindElement(By.PartialLinkText(ByString));
        }

        public override IWebElement findCssSelector(string ByString)
        {
            return driver.FindElement(By.CssSelector(ByString));
        }
    }
}

// https://galleru.us.auth0.com/u/login/identifier?state=hKFo2SBESEhUcnBJcVpLYmV0cFM2Z0Q0RkVXLWVVdHFUMS13N6Fur3VuaXZlcnNhbC1sb2dpbqN0aWTZIHg0d0NWMVRGNmtZbVZxSXBvYkdWZ0NsLUJ6NVhDN3VDo2NpZNkgTjB4amhNdkdzeW5uY29IVUlLMVhsM2RQR29ZZVFrTmE