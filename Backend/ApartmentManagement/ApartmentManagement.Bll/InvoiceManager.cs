using ApartmentManagement.Dal.Abstract;
using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;
using System;

namespace ApartmentManagement.Bll
{
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public readonly IInvoiceRepository ınvoiceRepository;

        public InvoiceManager(IServiceProvider service) : base(service)
        {
        }
    }
}
