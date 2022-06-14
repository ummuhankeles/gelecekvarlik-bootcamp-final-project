using ApartmentManagement.Entity.Dto;
using ApartmentManagement.Entity.Models;
using ApartmentManagement.Interface;

namespace ApartmentManagement.Bll
{
    public class InvoiceTypeManager : GenericManager<InvoiceType, DtoInvoiceType>, IInvoiceTypeService
    {
    }
}
