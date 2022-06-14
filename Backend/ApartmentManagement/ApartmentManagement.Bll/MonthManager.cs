using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class MonthManager : GenericManager<Month, DtoMonth>, IMonthService
    {
        public readonly IMonthRepository monthRepository;

        public MonthManager(IServiceProvider service) : base(service)
        {
        }
    }
}
