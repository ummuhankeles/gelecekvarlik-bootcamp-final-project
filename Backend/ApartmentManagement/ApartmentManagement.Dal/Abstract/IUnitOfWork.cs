using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        bool BeginTransection(); // transection başlatma
        bool RollBackTransection(); // hata durumunda sürecin geri alınmasını sağlayan işlem
        int SaveChanges(); // transection onaylama
    }
}
