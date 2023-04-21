using Day3.Entities;
using System.Data.Common;
using System.Text;

namespace Day3;

public class Program
{
    public static void Main()
    {
        //AnotherMethod();

        //int someInt = 0;
        //string str = "ADSFAF";

        //var i = 0d;
        //var list = new List<int>();

        ////i = "DSFsdf";

        //string strEx = "Hello"; // 0x00000223
        //// strEx[0] = 'J';
        //strEx = "anotherOne" + strEx;   // 0x00000002

        //StringBuilder sb = new StringBuilder("Hello World");
        //sb[0] = 'W';
        //Console.ReadKey();

        //Generics:
        //var comp = new Comparer<double>();
        //Console.WriteLine(comp.CheckEquality(10, 20));

        ////Console.WriteLine(comp.CheckEquality(10, "sdfasdf"));

        //var list = new List<List<string>>();
        //int input1 = Convert.ToInt32(Console.ReadLine());
        try
        {
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Int32.MaxValue);
            //Console.WriteLine(Int32.MinValue);
            //int max = Int32.MaxValue - 10;
            //max = max + 11;//checked(max + 120);
            //Console.WriteLine(max);
            //max = max - 11;
            //Console.WriteLine(max);

            var stud = new Student();
            stud.Age = 100;
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Program did not crash");
        }
        catch (OverflowException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        catch (AgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            // dispose
        }

        //using (DbConnection con)
        //{
        //    Console.WriteLine();
        //}
    }

    public static void AnotherMethod()
    {
        Console.WriteLine("Im being called");
    }
}