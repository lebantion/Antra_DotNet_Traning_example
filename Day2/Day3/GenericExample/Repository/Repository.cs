using Day3.Entities;
using Day3.GenericExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.GenericExample.Repository
{
    public class Repository<T> : IRepository<T>
    {
        List<T> _list;
        public Repository() 
        { 
            _list = new List<T>();
        }
        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
