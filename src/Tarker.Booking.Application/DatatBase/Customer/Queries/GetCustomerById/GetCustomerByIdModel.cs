
namespace Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerById
{
    public class GetCustomerByIdModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
    }
}
