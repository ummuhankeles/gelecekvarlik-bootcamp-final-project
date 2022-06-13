using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class InvoiceType : EntityBase
    {
        public InvoiceType()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int InvoiceTypeId { get; set; }
        public string InvoiceTypeName { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
