using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class Block : EntityBase
    {
        public Block()
        {
            Buildings = new HashSet<Building>();
        }

        public int BlockId { get; set; }
        public string BlockName { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}
