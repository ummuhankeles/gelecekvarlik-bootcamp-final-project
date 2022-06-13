using ApartmentManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoApartment : DtoBase
    {
        public DtoApartment()
        {
        }

        public int AprtId { get; set; }
        public int AprtFloor { get; set; }
        public int AprtRoomNo { get; set; }
        public bool AprtIsEmpty { get; set; }
        public int UserId { get; set; }

    }
}
