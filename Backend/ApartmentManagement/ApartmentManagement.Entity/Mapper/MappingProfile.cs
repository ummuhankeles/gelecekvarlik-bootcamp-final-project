using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Apartment, DtoApartment>().ReverseMap();
            CreateMap<Block, DtoBlock>().ReverseMap();
            CreateMap<Building, DtoBuilding>().ReverseMap();
            CreateMap<Invoice, DtoInvoice>().ReverseMap();
            CreateMap<Message, DtoMessage>().ReverseMap();
            CreateMap<Month, DtoMonth>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
        }
    }
}
