using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Base;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.IBase;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ApartmentManagement.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;
        private IConfiguration configuration;

        public UserManager(IServiceProvider service, IConfiguration configuration) : base(service)
        {
            userRepository = service.GetService<IUserRepository>();
            this.configuration = configuration;
        }

        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));

            if (user != null)
            {
                var dtoUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);

                var token = new TokenManager(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>
                {
                    Message = "Token is success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>
                {
                    Message = "Wrong username or password!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }

        public IResponse<DtoRegister> Register(DtoRegister register)
        {
            Random randomPassword = new Random();
            register.UserPassword = Convert.ToString(randomPassword.Next(100000, 1000000)); // random password üretildi
            var registerUser = userRepository.Register(ObjectMapper.Mapper.Map<User>(register));
            if (registerUser != null)
            {
                return new Response<DtoRegister>
                {
                    Message = "Personel Added!",
                    StatusCode = StatusCodes.Status200OK,
                    Data = register
                };
            }
            else
            {
                return new Response<DtoRegister>
                {
                    Message = "Personel didn't add!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
