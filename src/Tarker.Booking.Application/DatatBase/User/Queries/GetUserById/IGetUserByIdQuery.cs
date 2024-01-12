

namespace Tarker.Booking.Application.DatatBase.User.Queries.GetUserById
{
    public interface IGetUserByIdQuery
    {
        Task<GetUserByIdModel> Execute(int UserId);
    }
}
