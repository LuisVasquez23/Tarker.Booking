using AutoMapper;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Domain.Entities.Booking;

namespace Tarker.Booking.Application.DatatBase.Booking.Commands.CreateBooking
{
    public class CreateBookingCommand : ICreateBookingCommand
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;

        public CreateBookingCommand(IDataBaseService databaseService , IMapper mapper) { 
            _databaseService = databaseService; 
            _mapper = mapper;
        }

        public async Task<CreateBookingModel> Execute(CreateBookingModel model)
        {
            var entity = _mapper.Map<BookingEntity>(model);

            await _databaseService.Booking.AddAsync(entity);

            await _databaseService.SaveAsync();

            return model;

        }

    }
}
