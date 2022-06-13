using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoMessage : DtoBase
    {
        public int MessageId { get; set; }
        public string MessageHeader { get; set; }
        public string MessageContent { get; set; }
        public bool MessageIsRead { get; set; }
        public DateTime MessageDate { get; set; }
        public int UserId { get; set; }
    }
}
