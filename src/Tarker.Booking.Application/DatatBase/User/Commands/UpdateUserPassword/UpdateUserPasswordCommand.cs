using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.User.Commands.UpdateUserPassword
{
    public class UpdateUserPasswordCommand : IUpdateUserPasswordCommand
    {
        private readonly IDataBaseService _databaseService;

        public UpdateUserPasswordCommand(IDataBaseService databaseService)
        {
            _databaseService = databaseService; 
        }

        public async Task<bool> Excute(UpdateUserPasswordModel model)
        {
            var entity = await _databaseService.User.FirstOrDefaultAsync(x => x.UserId == model.UserId);

            if (entity == null)
            {
                return false;
            }

            entity.Password = model.Password;

            return await _databaseService.SaveAsync();
        }

    }
}
