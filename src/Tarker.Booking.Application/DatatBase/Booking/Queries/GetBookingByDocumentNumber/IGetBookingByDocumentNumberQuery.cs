namespace Tarker.Booking.Application.DatatBase.Booking.Queries.GetBookingByDocumentNumber
{
    public interface IGetBookingByDocumentNumberQuery
    {
        Task<List<GetBookingByDocumentNumberModel>> Execute(string documentNumber);
    }
}
