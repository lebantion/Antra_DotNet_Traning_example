using Day3.Entities;
using Day3.GenericExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.GenericExample.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public Student GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
