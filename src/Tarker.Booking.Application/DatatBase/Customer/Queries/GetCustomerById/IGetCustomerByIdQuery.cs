namespace Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerById
{
    public interface IGetCustomerByIdQuery
    {
        Task<GetCustomerByIdModel> Execute(int customerId);
    }
}
