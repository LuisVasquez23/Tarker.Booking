using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerById
{
    public class GetCustomerByIdQuery : IGetCustomerByIdQuery
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetCustomerByIdQuery(IDataBaseService databaseService , IMapper mapper) {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetCustomerByIdModel> Execute(int customerId)
        {
            var entity = await _databaseService.Customer.FirstOrDefaultAsync( x => x.CustomerId == customerId);

            return _mapper.Map<GetCustomerByIdModel>(entity);
        }

    }
}
