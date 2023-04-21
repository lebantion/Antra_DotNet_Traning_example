using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.GenericExample.Contracts
{
    public interface IRepository<T>
    {
        // CRUD
        // Repository Pattern
        // Single Responcibility Principle ( (S) OLID)
        void Add(T entity);
        void GetAll();
        void GetById(int id);
        void Update(T entity);
        void DeleteById(int id);
    }
}
