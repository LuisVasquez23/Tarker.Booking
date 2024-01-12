using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.User.Commands.DeleteUser
{
    public class DeleteUserCommand : IDeleteUserCommand
    {

        private readonly IDataBaseService _databaseService;

        public DeleteUserCommand(IDataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<bool> Execute(int userId)
        {
            var entity = await _databaseService.User.FirstOrDefaultAsync( x => x.UserId == userId );

            if (entity == null)
            {
                return false;
            }

            _databaseService.User.Remove( entity );

            return await _databaseService.SaveAsync();

        }

    }
}
