using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.Customer.Commands.UpdateCustomer
{
    public class UpdateCustomerModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
    }
}
