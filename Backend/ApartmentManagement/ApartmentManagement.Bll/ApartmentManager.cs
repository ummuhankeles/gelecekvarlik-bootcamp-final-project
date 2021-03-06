using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ApartmentManagement.Bll
{
    public class ApartmentManager : GenericManager<Apartment, DtoApartment>, IApartmentService
    {
        public readonly IApartmentRepository apartmentRepository;

        public ApartmentManager(IServiceProvider service) : base(service)
        {
            apartmentRepository = service.GetService<IApartmentRepository>();
        }
    }
}
