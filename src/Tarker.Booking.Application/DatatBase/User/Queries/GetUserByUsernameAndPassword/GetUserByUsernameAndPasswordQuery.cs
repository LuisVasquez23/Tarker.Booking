using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.User.Queries.GetUserByUsernameAndPassword
{
    public class GetUserByUsernameAndPasswordQuery : IGetUserByUsernameAndPasswordQuery
    {

        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetUserByUsernameAndPasswordQuery(IDataBaseService databaseService , IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetUserByUsernameAndPasswordModel> Execute(string userName , string password)
        {

            var entity = await _databaseService.User.FirstOrDefaultAsync( x => x.UserName == userName & x.Password == password);
            return _mapper.Map<GetUserByUsernameAndPasswordModel>(entity);

        }

    }
}
