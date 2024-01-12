using AutoMapper;
using Tarker.Booking.Application.DatatBase.Booking.Commands.CreateBooking;
using Tarker.Booking.Application.DatatBase.Booking.Queries.GetAllBooking;
using Tarker.Booking.Application.DatatBase.Customer.Commands.CreateCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Commands.UpdateCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetAllCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerByDocumentNumber;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerById;
using Tarker.Booking.Application.DatatBase.User.Commands.CreateUser;
using Tarker.Booking.Application.DatatBase.User.Commands.UpdateUser;
using Tarker.Booking.Application.DatatBase.User.Queries.GetAllUser;
using Tarker.Booking.Application.DatatBase.User.Queries.GetUserById;
using Tarker.Booking.Application.DatatBase.User.Queries.GetUserByUsernameAndPassword;
using Tarker.Booking.Domain.Entities.Booking;
using Tarker.Booking.Domain.Entities.Customer;
using Tarker.Booking.Domain.Entities.User;


namespace Tarker.Booking.Application.Configuration
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            // Users
            CreateMap<UserEntity, CreateUserModel>().ReverseMap(); 
            CreateMap<UserEntity, UpdateUserModel>().ReverseMap(); 
            CreateMap<UserEntity, GetAllUserModel>().ReverseMap(); 
            CreateMap<UserEntity, GetUserByIdModel>().ReverseMap(); 
            CreateMap<UserEntity, GetUserByUsernameAndPasswordModel>().ReverseMap();

            // Customers
            CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetAllCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();

            // Booking
            CreateMap<BookingEntity, CreateBookingModel>().ReverseMap();
        }

    }
}
