using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using ApartmentManagement.WebApi.Base;
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
    public class ApartmentController : ApiBaseController<IApartmentService, Apartment, DtoApartment>
    {
        private readonly IApartmentService apartmentService;
        public ApartmentController(IApartmentService apartmentService) : base(apartmentService)
        {
            this.apartmentService = apartmentService;
        }
    }
}
