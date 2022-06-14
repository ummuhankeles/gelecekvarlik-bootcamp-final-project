using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class MessageManager : GenericManager<Message, DtoMessage>, IMessageService
    {
        public readonly IMessageRepository messageRepository;

        public MessageManager(IServiceProvider service) : base(service)
        {
        }
    }
}
