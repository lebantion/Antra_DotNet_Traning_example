using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("This is called every time some Emp is made, no matter it being part time of full time");
        }
        public Employee(int id)
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Do some work Employee");
        }
    }

    public class FullTime : Employee
    {
        public FullTime()
        {
            
        }
        public int Salary { get; set; }
        // Polymorphism: overriding
        public override void Work()
        {
            Console.WriteLine("Do some work FullTime Employee");
        }
    }
    
    public class PartTime : Employee
    {
        public PartTime()
        {
            
        }

        //Method Hiding
        public new void Work()
        {
            Console.WriteLine("Do some work PartTime Employee");
        }

        //Polymorphism: Overloading
        //Three ways:
        //1. Change the number of parameter
        public void Work(int i)
        {
            Console.WriteLine("Do some work PartTime Employee " + i);
        }
        //2. Change the Data type of parameters
        public void Work(double i)
        {
            Console.WriteLine("Do some work PartTime Employee " + i);
        }
        //3 Change the Order of Parameters
        public void Work(int i, string str)
        {
            Console.WriteLine("Do some work PartTime Employee " + i + str);
        }
        public void Work(string str, int i)
        {
            Console.WriteLine("Do some work PartTime Employee " + i + str);
        }

        // Honorary: Change the return type
        // it is an honorary mention because you still have to change one of the above
        public string Work(int i, int a)
        {
            Console.WriteLine("Do some work PartTime Employee " + i);
            return "";
        }
    }
}
