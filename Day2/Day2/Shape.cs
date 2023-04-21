using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //Abstraction: 
    // Abstract classes vs classes:
    /*
     abstract classes cannot be instantiated but concrete classes can
    as long as one abstract method is in the class, then the class must be abstract
    abstract classes can contain concrete methods as well as abstract methods
     */
    //Abstract vs Virtual
    // abstract doesnt provide an implementation and forces the derived class to override the method
    // Virtual can have the implemenation and also provides the OPTION of overriding the method
    public abstract class Shape
    {
        public Shape()
        {
           
        }
        public int Id { internal get; set; }
        public string Name { get; set; }
        public virtual void PrintShape() 
        {
            Console.WriteLine(Name);
        }
        public abstract int GetId();
    }
    public class Square : Shape
    {
        public override int GetId()
        {
            return Id;
        }
    }
}
