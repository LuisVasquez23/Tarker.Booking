using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;

namespace Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerByDocumentNumber
{
    public class GetCustomerByDocumentNumberQuery : IGetCustomerByDocumentNumberQuery
    {

        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public GetCustomerByDocumentNumberQuery(IDataBaseService databaseService , IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetCustomerByDocumentNumberModel> Execute(string documentNumber)
        {
            var entity = await _databaseService.Customer.FirstOrDefaultAsync( x => x.DocumentNumber == documentNumber);
            return _mapper.Map<GetCustomerByDocumentNumberModel>(entity);
        }

    }
}
