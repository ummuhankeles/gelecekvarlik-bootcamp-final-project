using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Dto
{
    public class DtoUserToken
    {
        public DtoLoginUser DtoLoginUser { set; get; }
        public object AccessToken { get; set; }
    }
}
