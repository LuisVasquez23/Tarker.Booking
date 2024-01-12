using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetBookingByType
{
    public interface IGetBookingByTypeCommand
    {
        Task<List<GetBookingByTypeModel>> Execute(string type);
    }
}
