using Day3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.GenericExample.Contracts
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetByName(string name);
    }
}
