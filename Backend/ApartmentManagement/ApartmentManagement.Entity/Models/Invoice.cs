using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class Invoice : EntityBase
    {
        public int InvoiceId { get; set; }
        public double InvoiceAmount { get; set; }
        public bool InvoiceStatus { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int AprtId { get; set; }
        public int UserId { get; set; }
        public int InvoiceTypeId { get; set; }
        public int MonthId { get; set; }

        public virtual Apartment Aprt { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }
        public virtual Month Month { get; set; }
        public virtual User User { get; set; }
    }
}
