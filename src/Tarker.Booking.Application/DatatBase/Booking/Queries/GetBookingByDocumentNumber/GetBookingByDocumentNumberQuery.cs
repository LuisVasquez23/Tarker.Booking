
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetBookingByDocumentNumber
{
    public class GetBookingByDocumentNumberQuery : IGetBookingByDocumentNumberQuery
    {
        private readonly IDataBaseService _databaseService;

        public GetBookingByDocumentNumberQuery(IDataBaseService databaseService)
        {
            _databaseService = databaseService; 
        }

        public async Task<List<GetBookingByDocumentNumberModel>> Execute(string documentNumber)
        {
            var listEntity = await (
                                from booking in _databaseService.Booking
                                join customer in _databaseService.Customer on booking.CustomerId equals customer.CustomerId
                                where customer.DocumentNumber == documentNumber
                                select new GetBookingByDocumentNumberModel
                                {
                                    Code = booking.Code,
                                    RegisterDate = booking.RegisterDate,
                                    Type = booking.Type,    
                                }).ToListAsync();

            return listEntity;
        }
    }
}
