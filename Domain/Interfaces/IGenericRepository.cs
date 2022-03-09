using _2106_Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _2106_Project.Domain.Interfaces
{
    public interface IGenericRepository<T> where T: class {

        List<T> GetAll();
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object entity);
        IEnumerable<T> Find (Expression<Func<T, bool>> expression);  
    }
}
