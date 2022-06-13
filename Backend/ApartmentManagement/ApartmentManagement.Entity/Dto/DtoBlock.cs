using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoBlock : DtoBase
    {
        public DtoBlock()
        {
        }

        public int BlockId { get; set; }
        public string BlockName { get; set; }
    }
}
