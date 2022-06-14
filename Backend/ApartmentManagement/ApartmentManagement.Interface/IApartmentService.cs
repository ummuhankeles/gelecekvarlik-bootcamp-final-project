using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;

namespace ApartmentManagement.Interface
{
    public interface IApartmentService : IGenericService<Apartment, DtoApartment>
    {
    }
}
