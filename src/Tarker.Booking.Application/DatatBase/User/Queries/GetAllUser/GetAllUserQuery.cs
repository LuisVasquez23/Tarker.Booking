using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.User.Queries.GetAllUser
{
    public class GetAllUserQuery : IGetAllUserQuery
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllUserQuery(IDataBaseService databaseService , IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllUserModel>> Execute()
        {
            var listEntity = await _databaseService.User.ToListAsync();

            return _mapper.Map<List<GetAllUserModel>>(listEntity);
        }




    }
}
