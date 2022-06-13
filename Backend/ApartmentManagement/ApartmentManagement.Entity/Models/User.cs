using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class User : EntityBase
    {
        public User()
        {
            Apartments = new HashSet<Apartment>();
            Invoices = new HashSet<Invoice>();
            Messages = new HashSet<Message>();
        }

        public int UserId { get; set; }
        public string UserTcno { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserUsername { get; set; }
        public string UserPassword { get; set; }
        public int UserPhoneNumber { get; set; }
        public string UserCarInfo { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
