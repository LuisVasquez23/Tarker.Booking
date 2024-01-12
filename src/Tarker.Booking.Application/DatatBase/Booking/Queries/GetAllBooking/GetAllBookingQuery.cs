using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetAllBooking
{
    public class GetAllBookingQuery : IGetAllBookingQuery
    {
        private readonly IDataBaseService _databaseService;

        public GetAllBookingQuery(IDataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<List<GetAllBookingModel>> Execute()
        {
            var entity = await (
                    from booking in _databaseService.Booking
                    join customer in _databaseService.Customer on booking.CustomerId equals customer.CustomerId
                    select new GetAllBookingModel
                    {
                        BookingId = booking.BookingId,
                        Code = booking.Code,
                        RegisterDate = booking.RegisterDate,
                        Type = booking.Type,
                        CustomerFullName = customer.FullName,
                        CustomerDocumentNumber = customer.DocumentNumber,
                    }).ToListAsync();

            return entity;
        }
    }
}
