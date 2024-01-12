using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetAllBooking
{
    public interface IGetAllBookingQuery
    {
        Task<List<GetAllBookingModel>> Execute();
    }
}
