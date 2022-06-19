using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoRegister : DtoBase
    {
        [Required]
        public string UserTcno { get; set; }
        
        [Required]
        public string UserFullName { get; set; }
        
        [Required]
        public string UserEmail { get; set; }
        
        [Required]
        public string UserUsername { get; set; }
        
        [Required]
        public string UserPassword { get; set; }
       
        public string UserPhoneNumber { get; set; }
        
        [Required]
        public string UserCarInfo { get; set; }

        [Required]
        public int RoleId = 2;
    }
}
