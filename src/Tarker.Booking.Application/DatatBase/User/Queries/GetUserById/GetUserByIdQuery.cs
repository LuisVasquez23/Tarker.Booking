using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.User.Queries.GetUserById
{
    public class GetUserByIdQuery : IGetUserByIdQuery
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetUserByIdQuery(IDataBaseService dataBaseService , IMapper mapper) {
            _databaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<GetUserByIdModel> Execute(int UserId)
        {
            var entity = await _databaseService.User.FirstOrDefaultAsync( x => x.UserId == UserId);

            return _mapper.Map<GetUserByIdModel>(entity); 
        }

    }
}
