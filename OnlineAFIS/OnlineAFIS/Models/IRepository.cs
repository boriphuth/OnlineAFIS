using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineAFIS.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
