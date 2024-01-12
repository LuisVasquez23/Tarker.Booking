namespace Tarker.Booking.Application.DatatBase.Customer.Commands.DeleteCustomer
{
    public interface IDeleteCustomerCommand
    {
        Task<bool> Execute(int customerId);
    }
}
