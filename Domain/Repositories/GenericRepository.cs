using _2106_Project.Data;
using _2106_Project.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2106_Project.Domain.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        protected ApplicationDbContext context;
        protected DbSet<T> dbSet;

        private ApplicationDbContext _entities;
        public GenericRepository(ApplicationDbContext context){

            _entities = context;

            this.context = context;
/*            this.dbSet = context.Set<T>();
*/        }

        public ApplicationDbContext db
        {

            get { return _entities; }
            set { _entities = value; }
        }

        public virtual List<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query.ToList();
        }

        public virtual T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
/*            dbSet.Add(entity);
*/            _entities.Set<T>().Add(entity);

        }

        public virtual void Delete(object entity)
        {
            T entityToDelete = dbSet.Find(entity);
            Delete(entityToDelete);

        }
        public virtual void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }
        public virtual void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
