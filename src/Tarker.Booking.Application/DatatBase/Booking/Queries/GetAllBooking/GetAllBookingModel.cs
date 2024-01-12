namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetAllBooking
{
    public class GetAllBookingModel
    {
        public int BookingId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string CustomerFullName { get; set; }
        public string CustomerDocumentNumber { get; set; }
    }
}
