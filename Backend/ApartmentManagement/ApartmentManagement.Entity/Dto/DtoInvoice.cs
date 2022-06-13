using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoInvoice : DtoBase
    {
        public int InvoiceId { get; set; }
        public double InvoiceAmount { get; set; }
        public bool InvoiceStatus { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int AprtId { get; set; }
        public int UserId { get; set; }
        public int InvoiceTypeId { get; set; }
        public int MonthId { get; set; }
    }
}
