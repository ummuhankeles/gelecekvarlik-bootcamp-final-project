using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.IBase;
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
        IResponse<DtoUserToken> Login(DtoLogin login);
        IResponse<DtoRegister> Register(DtoRegister register);
    }
}
