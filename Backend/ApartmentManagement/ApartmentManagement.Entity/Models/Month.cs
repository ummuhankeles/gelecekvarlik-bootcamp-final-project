using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class Month : EntityBase
    {
        public Month()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int MonthId { get; set; }
        public string MonthName { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
