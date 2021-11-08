using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    static class ExtClass
    {
        public static int Power(this int a)
        {
            return a*a*a;
        }
    }
}
