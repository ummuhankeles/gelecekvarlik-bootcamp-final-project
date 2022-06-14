using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class BuildingManager : GenericManager<Building, DtoBuilding>, IBuildingService
    {
        public readonly IBuildingRepository buildingRepository;

        public BuildingManager(IServiceProvider service) : base(service)
        {
        }
    }
}
