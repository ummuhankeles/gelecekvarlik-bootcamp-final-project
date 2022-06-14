using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Dal.Concrete.EntityFramework.Repository;
using ApartmentManagement.Entity.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Dal.Concrete.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables
        DbContext context;
        IDbContextTransaction transection;
        bool dispose; // nesne yönetimi için
        #endregion

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public bool BeginTransection()
        {
            try
            {
                transection = context.Database.BeginTransaction();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // garbage collector çalıştırır
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!dispose)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            dispose = true;
        }

        public IGenericRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new GenericRepository<T>(context); // modele ait insert.. vb. tek bir context ten yönetmel
        }

        public bool RollBackTransection()
        {
            try
            {
                transection.Rollback();
                transection = null;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int SaveChanges()
        {
            var _transection = transection != null ? transection : context.Database.BeginTransaction();
            using (_transection) // hata olsada olmasada oluşturduğumuz _transection u öldürüyoruz
            {
                try
                {
                    if (context == null)
                    {
                        // context null ise işlem yapamayız
                        throw new ArgumentException("Context is null");
                    }

                    int result = context.SaveChanges(); // etkilenen satır sayısını döndürür

                    _transection.Commit();

                    return result; // etkilenen satır sayısı yoksa sıfırdır
                }
                catch (Exception ex)
                {
                    transection.Rollback();
                    throw new Exception("Error on save changes", ex);
                }
            }
        }
    }
}
