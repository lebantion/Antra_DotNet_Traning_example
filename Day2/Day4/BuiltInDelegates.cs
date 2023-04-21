using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    // Built In Delegates: Action, Predicate, Func
    public class BuiltInDelegates
    {
        public static void UsingFunctionPointer(int a)
        {
            Console.WriteLine(a);
        }

        public static bool UsingFunctionPointer(params int[] a)
        {
            Console.WriteLine(a);
            return true;
        }

        //Action: it technically takes in up to 16 different specified types
        // but returns void

        public static void ActionExample()
        {
            Action<int> action1 = UsingFunctionPointer;
            Action<int> action2 = intParameter =>
            {
                int a = 0;
                int b = 1;
                Console.WriteLine(a + b * intParameter);
            };
            action2(100);
            
            Action<int> action3 = intPara =>
            {
                int a = 0, b = 1, c = 2;
                for(int i = 0; i< intPara; i++)
                {
                    Console.WriteLine(a + " ");
                    c = a + b;
                    a = b;
                    b = c;
                }
                
            };
            action3(25);
        }
        //Predicate: built in Delegate that takes one input of different specified type
        // but returns boolean
        public static void PredicateExample()
        {
            Predicate<string> longerthan1 = (str) =>
            {
                if (str.Length > 10)
                {
                    return true;
                }
                return false;
            };
            //Not supported: maybe in the future.
            //Predicate<int[]> anyInt = (params int[] b) =>
            //{
            //    return true;
            //};
            
            Predicate<int[]> anyInt = UsingFunctionPointer;
        }

        // Func: built in delegate that takes up to 16 parameters and
        // an output of a specific type
        public void FuncExample()
        {
            Func<int, int, bool> funcExample = (x, y) =>
            {
                if (x < 100 || y < 50) return true;
                return false;
            };
            
        }
    }
}
