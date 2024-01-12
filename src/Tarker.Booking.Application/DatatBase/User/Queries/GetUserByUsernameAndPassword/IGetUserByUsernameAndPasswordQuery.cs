using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.User.Queries.GetUserByUsernameAndPassword
{
    public interface IGetUserByUsernameAndPasswordQuery
    {
        Task<GetUserByUsernameAndPasswordModel> Execute(string userName, string password);
    }
}
