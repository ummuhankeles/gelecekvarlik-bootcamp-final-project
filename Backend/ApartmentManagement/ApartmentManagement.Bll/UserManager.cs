﻿using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;

namespace ApartmentManagement.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        
    }
}