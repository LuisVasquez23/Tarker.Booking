using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.Booking.Commands.CreateBooking
{
    public class CreateBookingModel
    {
        public DateTime RegisterDate { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public int UserId { get; set; }
    }
}
