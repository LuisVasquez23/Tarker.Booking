using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetBookingByType
{
    public class GetBookingByTypeCommand : IGetBookingByTypeCommand
    {

        private readonly IDataBaseService _databaseService;

        public GetBookingByTypeCommand(IDataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<List<GetBookingByTypeModel>> Execute(string type)
        {

            var entity = await (
                        from booking in _databaseService.Booking
                        join customer in _databaseService.Customer on booking.CustomerId equals customer.CustomerId
                        where booking.Type == type
                        select new GetBookingByTypeModel
                        {
                            RegisterDate = booking.RegisterDate,
                            Code = booking.Code,
                            Type = booking.Type,
                            CustomerFullName = customer.FullName,
                            CustomerDocumentNumber = customer.DocumentNumber
                        }).ToListAsync();

            return entity;

        }


    }
}
