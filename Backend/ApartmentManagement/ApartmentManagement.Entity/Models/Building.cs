using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class Building : EntityBase
    {
        public int BuildingsId { get; set; }
        public string BuildingsName { get; set; }
        public int AprtId { get; set; }
        public int BlockId { get; set; }

        public virtual Apartment Aprt { get; set; }
        public virtual Block Block { get; set; }
    }
}
