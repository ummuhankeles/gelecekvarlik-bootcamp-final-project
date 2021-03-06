using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoUser : DtoBase
    {
        public DtoUser()
        {
        }

        public int UserId { get; set; }
        public string UserTcno { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserUsername { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserCarInfo { get; set; }
        public int RoleId { get; set; }
    }
}
