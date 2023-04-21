using Day2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Arithmetic : IArithmetic
    {
        public const int N = 10;

        
        public void Addition(params int[] values)
        {
            HelpingHand.Multiply(1, 2);
            
        }

        public void Subtraction(params int[] values)
        {
            throw new NotImplementedException();
        }
    }

    public class HelpingHand
    {
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
