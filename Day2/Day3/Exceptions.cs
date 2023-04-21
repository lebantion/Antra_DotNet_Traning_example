using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class AgeException : Exception
    {
        public override string Message => "Age Must be over 18-65";
    }
}
