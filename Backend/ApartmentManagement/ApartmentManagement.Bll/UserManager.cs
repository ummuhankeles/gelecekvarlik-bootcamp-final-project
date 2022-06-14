using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;

        public UserManager(IServiceProvider service) : base(service)
        {
        }
    }
}
