using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public static class ExtensionMethod
    {
        /*Extension Methods:
         *  the class containing these extension methods must be a static class
         *  The extension method as a result is required to be a static method.
         *  the fist parameter needs to have a "this" keyword to specify which
         *  type is being extended
         */
        public static void IsEven(this int x, int a)
        {
            if (x % 2 == 0) return;
        }
    }
}
