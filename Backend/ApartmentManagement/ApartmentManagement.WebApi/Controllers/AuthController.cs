using ApartmentManagement.Entity.Base;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.IBase;
using ApartmentManagement.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;
        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Login")]
        // [AllowAnonymous] // metodu token dan hariç tut
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            try
            {
                return userService.Login(login);
            }
            catch (Exception ex)
            {
                return new Response<DtoUserToken>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        [HttpPost("Register")]
        public IResponse<DtoRegister> Register(DtoRegister register)
        {
            try
            {
                return userService.Register(register);
            }
            catch (Exception ex)
            {
                return new Response<DtoRegister>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
