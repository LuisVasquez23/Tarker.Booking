using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.User.Commands.CreateUser
{
    public interface ICreateUserCommand
    {
        Task<CreateUserModel> Execute(CreateUserModel model);
    }
}
