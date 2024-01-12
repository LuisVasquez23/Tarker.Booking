
namespace Tarker.Booking.Application.DatatBase.User.Queries.GetAllUser
{
    public interface IGetAllUserQuery
    {
        Task<List<GetAllUserModel>> Execute();
    }
}
