using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGalerU
{
    internal class Tests
    {
        public static void test1()
        {
            stripRunner.signUp("achiya@gmail.com", "Abcd!2#$");
            stripRunner.signUp("achiya", "Abcd!2#$");
        }
    }
}
