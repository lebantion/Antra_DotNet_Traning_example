using LowerthanSix;
using System.Data.Common;

namespace Day2;


public class Program
{
    public int i = 10;
    public static void Main()
    {
        // Object Oriented Programming

        Student student = new Student();
        //Something something = new LowerthanSix.Something();

        Employee emp = new Employee();
        FullTime full = new FullTime();
        Employee fullemp = new FullTime();
        Employee partemp = new PartTime();
        PartTime part = new PartTime();

        //emp.Salary;
        full.Salary = 1000;
        emp.Work(); //Just Employee -> Emp
        full.Work(); //FullTime -> fulltime
        WorkingEmp(fullemp); // Emp as Full

        part.Work();          //Part as Part
        WorkingEmp(partemp);  // Emp as Part


        Shape shape = new Square();

        FullTime f2 = (FullTime)fullemp;
        //Convert.ToString
        f2.Salary = 1000;

        //Boxing
        int someValue = 1234;
        object obj = (object)someValue;

        //Unbox
        int another = (int)obj;

        //
        // constructors can be overloaded with multiple paramters
        // if there is no constructor, then the complier provides a default ctor
        // a default ctor is always replaced by any custom ctor  
        // ctor is used to initialize the class fields
        // constructors do not have return type
        // the derived class constructor will automatically make a call to the
        // / base class parameterless constructor.

        // Sealed
        // Static
        HelpingHand.Multiply(123, 232);
        Console.WriteLine(Arithmetic.N);
    }

    public static void WorkingEmp(Employee emp)
    {
        emp.Work();
    }
}