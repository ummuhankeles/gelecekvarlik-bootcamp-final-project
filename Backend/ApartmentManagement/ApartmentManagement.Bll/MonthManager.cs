using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;

namespace ApartmentManagement.Bll
{
    public class MonthManager : GenericManager<Month, DtoMonth>, IMonthService
    {
    }
}
