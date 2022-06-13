using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoBuilding : DtoBase
    {
        public int BuildingsId { get; set; }
        public string BuildingsName { get; set; }
        public int AprtId { get; set; }
        public int BlockId { get; set; }
    }
}
