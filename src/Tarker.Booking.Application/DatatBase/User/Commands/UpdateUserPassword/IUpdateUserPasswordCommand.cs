using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DatatBase.User.Commands.UpdateUserPassword
{
    public interface IUpdateUserPasswordCommand
    {
        Task<bool> Excute(UpdateUserPasswordModel model);
    }
}
