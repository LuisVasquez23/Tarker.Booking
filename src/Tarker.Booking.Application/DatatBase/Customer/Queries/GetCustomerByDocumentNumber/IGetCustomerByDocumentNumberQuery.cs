

namespace Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerByDocumentNumber
{
    public interface IGetCustomerByDocumentNumberQuery
    {
        Task<GetCustomerByDocumentNumberModel> Execute(string documentNumber);
    }
}
