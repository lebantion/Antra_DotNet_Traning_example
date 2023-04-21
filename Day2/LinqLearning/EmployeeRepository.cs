using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    public class EmployeeRepository
    {
        // DbContext();
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Sean", Age= 50,
                Department= "It"},
                new Employee() {Id = 2, Name = "Tianle", Age= 51,
                Department= "Sales"},
                new Employee() {Id = 3, Name = "Weilei", Age= 52,
                Department= "HR"},
                new Employee() {Id = 4, Name = "Elaine", Age= 53,
                Department= "Marketing"},
                new Employee() {Id = 5, Name = "Simon", Age= 54,
                Department= "It"}
            };
        }
    }
}
