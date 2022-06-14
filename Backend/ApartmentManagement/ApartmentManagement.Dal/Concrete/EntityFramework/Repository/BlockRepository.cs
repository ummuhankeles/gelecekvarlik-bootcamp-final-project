using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Dal.Concrete.EntityFramework.Repository
{
    public class BlockRepository : GenericRepository<Block>, IBlockRepository
    {
        public BlockRepository(DbContext context) : base(context)
        {
        }
    }
}
