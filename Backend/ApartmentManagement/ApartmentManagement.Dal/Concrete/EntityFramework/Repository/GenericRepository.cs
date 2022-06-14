using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApartmentManagement.Dal.Concrete.EntityFramework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        #region Variables
        protected DbContext context;
        protected DbSet<T> dbSet;
        #endregion

        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<T>();
        }

        #region Methods
        public T Add(T item)
        {
            context.Entry(item).State = EntityState.Added;
            dbSet.Add(item);

            return item;
        }

        public async Task<T> AddAsync(T item)
        {
            context.Entry(item).State = EntityState.Added;
            await dbSet.AddAsync(item);

            return item;
        }

        public bool Delete(int id)
        {
            return Delete(Find(id));
        }

        public bool Delete(T item)
        {
            if (context.Entry(item).State == EntityState.Detached)
            {
                context.Attach(item);
            }

            return dbSet.Remove(item) != null;
        }

        public T Find(int id)
        {
            return dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).ToList();
        }

        public IQueryable<T> GetQueryable()
        {
            return dbSet.AsQueryable();
        }

        public T Update(T item)
        {
            dbSet.Update(item);
            return item;
        }
        #endregion
    }
}
