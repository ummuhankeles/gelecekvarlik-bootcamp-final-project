using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentManagement.Entity.Models
{
    public partial class Message : EntityBase
    {
        public int MessageId { get; set; }
        public string MessageHeader { get; set; }
        public string MessageContent { get; set; }
        public bool MessageIsRead { get; set; }
        public DateTime MessageDate { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
