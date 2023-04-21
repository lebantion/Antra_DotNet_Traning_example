using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Interfaces
{
    /*
     Interfaces is a contract which forces derived classes to implement it
    Interfaces by default has all members to be public
    interfaces cannot have constructors, abstract can
    interfaces can only have method declaration not implementation
    interfaces cannot have variables, but can have properties (because properties are methods)
    you cannot bake instance of an interface like abstract
    interfaces can support multiple inheritance but classes cannot

    class : class (abstract or concrete), IInterfaces, IInterface2...

    Interfaces vs Abstract
     */
    public interface IArithmetic
    {
        public void Addition(params int[] values);
        public void Subtraction(params int[] values);
    }
}
