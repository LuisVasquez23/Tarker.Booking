namespace Tarker.Booking.Application.DatatBase.Customer.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        Task<CreateCustomerModel> Execute(CreateCustomerModel model);
    }
}
