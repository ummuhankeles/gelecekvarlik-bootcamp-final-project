using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Interface
{
    public interface IUserService : IGenericService<User, DtoUser>
    {
    }
}
