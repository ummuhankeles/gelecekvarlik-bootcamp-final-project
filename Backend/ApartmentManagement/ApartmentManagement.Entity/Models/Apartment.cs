using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class Apartment : EntityBase
    {
        public Apartment()
        {
            Buildings = new HashSet<Building>();
            Invoices = new HashSet<Invoice>();
        }

        public int AprtId { get; set; }
        public int AprtFloor { get; set; }
        public int AprtRoomNo { get; set; }
        public bool AprtIsEmpty { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
