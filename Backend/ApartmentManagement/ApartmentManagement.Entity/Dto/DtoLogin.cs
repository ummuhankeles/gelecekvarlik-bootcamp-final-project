﻿using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoLogin : DtoBase
    {
        [Required]
        [StringLength(maximumLength:30)]
        [DataType(DataType.Text)]
        public string UserUsername { get; set; }

        [Required]
        [StringLength(maximumLength: 12)]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}
