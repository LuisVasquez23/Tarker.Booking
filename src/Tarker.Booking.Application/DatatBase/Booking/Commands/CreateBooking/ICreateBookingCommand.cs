
namespace Tarker.Booking.Application.DatatBase.Booking.Commands.CreateBooking
{
    public interface ICreateBookingCommand
    {
        Task<CreateBookingModel> Execute(CreateBookingModel model);
    }
}
