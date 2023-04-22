using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Department { get; set; }

        ////Navigation Properties
        //public int DepartmentId { get; set; }
        //public Department Department  { get; set; }
    }
}
