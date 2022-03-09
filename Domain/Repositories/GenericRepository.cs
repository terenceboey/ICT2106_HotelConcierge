using _2106_Project.Data;
using _2106_Project.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _2106_Project.Domain.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private ApplicationDbContext _entities;
        public GenericRepository(ApplicationDbContext context){

            _entities = context;
   }

        public virtual List<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query.ToList();
        }

        public virtual T GetById(object id)
        {
            return _entities.Set<T>().Find(id);
        }

        public virtual void Insert(T entity)
        {
             _entities.Set<T>().Add(entity);

        }

        public virtual void Delete(object entity)
        {
            T entityToDelete = _entities.Set<T>().Find(entity);
            _entities.Set<T>().Remove(entityToDelete);

        }
        public virtual void Update(T entityToUpdate)
        {
            _entities.Set<T>().Attach(entityToUpdate);
            _entities.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _entities.Set<T>().Where(expression);
        }
    }
}
