using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class BlockManager : GenericManager<Block, DtoBlock>, IBlockService
    {
        public readonly IBlockRepository blockRepository;

        public BlockManager(IServiceProvider service) : base(service)
        {
        }
    }
}
