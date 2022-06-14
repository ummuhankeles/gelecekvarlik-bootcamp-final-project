﻿using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Dal.Concrete.EntityFramework.Repository
{
    public class InvoiceTypeRepository : GenericRepository<InvoiceType>, IInvoiceTypeRepository
    {
        public InvoiceTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
