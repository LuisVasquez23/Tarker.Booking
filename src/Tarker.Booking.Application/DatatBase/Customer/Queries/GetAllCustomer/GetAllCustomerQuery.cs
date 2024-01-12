using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.DatatBase.User.Queries.GetAllUser;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.Customer.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery : IGetAllCustomerQuery
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllCustomerQuery(IDataBaseService databaseService , IMapper mapper) {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllCustomerModel>> Execute()
        {
            var listEntity = await _databaseService.Customer.ToListAsync();

            return _mapper.Map<List<GetAllCustomerModel>>(listEntity);
        }

    }
}
