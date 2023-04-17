using automation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGalerU
{
    internal class stripRunner
    {
        public static void run_login()
        {
            testElement test = new testElement();
            test.run("https://blue-field-01c0eaf03.3.azurestaticapps.net/");
        }

        public static void signUp(string email, string Password)
        {
            testElement test = new testElement();
            test.SignUp("https://blue-field-01c0eaf03.3.azurestaticapps.net", email, Password);
        }

    }
}
