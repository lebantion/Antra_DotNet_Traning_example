using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    public class EmployeeService
    {
        // Data -> Repositories -> Services (Business Logic)
        //readonly vs const: readonly doesnt have to be instantiated after
        //declartion and can be done later
        const int PI =3;
        private readonly EmployeeRepository emp;
        public EmployeeService()
        {
            emp = new EmployeeRepository();
        }

        public void Demo()
        {
            var list = emp.GetEmployees();

            //Select * From Employees
            // Query Comprehension Syntax
            var resultq1 = (from x in list select x).ToList();
            //Lambda expression
            var result1 = list.Select(x => x).ToList();

            //Select Id, Name From Employees
            var result2 = list.Select(x => new
            {
                Id = x.Id,
                Name = x.Name
            });
            // Query syntax
            var resultq2 = (from emp in list
                           select new
                           {
                               Id = emp.Id,
                               Name = emp.Name
                           }).ToList();

            //Lambda
            var result3 = list.Where(emp => emp.Id > 3).Select(x => x.Name);
            //Query 
            var resultq3 = (from emp in list
                            where emp.Id > 3
                            select emp.Name).ToList();

            //Aggregates
            var total = list.Sum(x => x.Age);
            Console.WriteLine(total);

            //Group By
            var resultGroupBy = list.GroupBy(x => x.Department).Select(emp => new
            {
                Department = emp.Key,
                TotalAge = emp.Sum(e => e.Age),
                AverageAge = Math.Round(emp.Average(e => e.Age), 2)
            });

            //Quantifiers:
            var resultQuant = list.Any(emp => emp.Age > 52);

            // --**
            var resultFirst = list.First(emp => emp.Id == 0); //it grabs the first result and returns it
                                                                //if there is no results, returns an
                                                                //exception.
            var resultFirstoD = list.Select(emp => new { Id = emp.Id })
                .FirstOrDefault(emp => emp.Id == 5) ?? new { Id = -1 };

            // (Condition) ? (true)value : (false)alternative
            //      value ?? alternative

            // **

            var resultSingle = list.Single(emp => emp.Id == 1);
            var rSingleorDef = list.SingleOrDefault(emp => emp.Id == 2) ?? new Employee() { Id = -1 };


            //Assignment: Implement LINQ pagination with skip and Take
            //SKip and Take methods in LINQ:
        }
    }
}
