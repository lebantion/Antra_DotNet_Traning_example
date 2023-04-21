using System.Collections;

namespace Day4;

public class Program
{
    public static void Main()
    {
        //int a = 100;
        //a.IsEven(200);
        ////List<int> list = new List<int>();
        ////list.Where(x => x > 0).ToList();
        //var arith = new Arithmetic();
        //var mathDelegate = new MathDelegate(arith.Addition);
        //mathDelegate += arith.Subtraction;
        //var listDel = mathDelegate.GetInvocationList();

        //Console.WriteLine(listDel.Length);
        //mathDelegate(100, 200);
        //arith.UseDelegateAsParameter(mathDelegate, 1000, 10000);
        //mathDelegate -= arith.Subtraction;
        //mathDelegate = null;
        ////mathDelegate += arith.Multiply;

        //arith.DivisionForEvenNumbers( (x,y) => {
        //    if ((x / y) % 2 == 0) return true;
        //    return false;
        //});

        //BuiltInDelegates.ActionExample();


        //var anonObject = new { Id = 1, Name = "Simon", Phone = true };
        // anonObject.Id = 2;

        dynamic d = true;
        d = 1000;
        d = "something in particlar";
        var v = 100;
        //v = "sdfdsf";

        List<int> list = new List<int>();
        Stack t = new Stack();
        t.Push(1);
        t.Push(true);
        t.Push("anystring");
        foreach( var item in t)
        {
            Console.WriteLine(item);
        }

        Stack<int> intStack = new Stack<int>();
        intStack.Push(12345);
    }
}