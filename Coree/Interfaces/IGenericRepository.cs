using System;
using System.Collections.Generic;
using System.Text;

namespace Coree.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Functionality to retrive all data for specifiec type
        IEnumerable<T> GetAll();

        T GetById(Object id); // object because it could be integer or string or any data type

        void Insert(T entity);
        void Update(T entity);
        void delete(Object id);
    }
}
