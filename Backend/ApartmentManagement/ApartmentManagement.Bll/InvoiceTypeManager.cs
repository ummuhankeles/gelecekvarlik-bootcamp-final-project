using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class InvoiceTypeManager : GenericManager<InvoiceType, DtoInvoiceType>, IInvoiceTypeService
    {
        public readonly IInvoiceTypeRepository ınvoiceTypeRepository;

        public InvoiceTypeManager(IServiceProvider service) : base(service)
        {
        }
    }
}
