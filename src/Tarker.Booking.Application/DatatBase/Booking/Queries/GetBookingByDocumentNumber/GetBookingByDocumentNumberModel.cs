﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetBookingByDocumentNumber
{
    public class GetBookingByDocumentNumberModel
    {
        public DateTime RegisterDate { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}
