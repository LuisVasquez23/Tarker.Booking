using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Tarker.Booking.Application.Configuration;
using Tarker.Booking.Application.DatatBase.Booking.Commands.CreateBooking;
using Tarker.Booking.Application.DatatBase.Booking.Queries.GetAllBooking;
using Tarker.Booking.Application.DatatBase.Booking.Queries.GetBookingByDocumentNumber;
using Tarker.Booking.Application.DatatBase.Customer.Commands.CreateCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Commands.DeleteCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Commands.UpdateCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetAllCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerByDocumentNumber;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerById;
using Tarker.Booking.Application.DatatBase.User.Commands.CreateUser;
using Tarker.Booking.Application.DatatBase.User.Commands.DeleteUser;
using Tarker.Booking.Application.DatatBase.User.Commands.UpdateUser;
using Tarker.Booking.Application.DatatBase.User.Commands.UpdateUserPassword;
using Tarker.Booking.Application.DatatBase.User.Queries.GetAllUser;
using Tarker.Booking.Application.DatatBase.User.Queries.GetUserById;
using Tarker.Booking.Application.DatatBase.User.Queries.GetUserByUsernameAndPassword;


namespace Tarker.Booking.Application
{
    public static class DependencyInjectionService
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());
            
            // Users
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
            services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
            services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
            services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
            services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
            services.AddTransient<IGetUserByUsernameAndPasswordQuery, GetUserByUsernameAndPasswordQuery>();

            // Customers
            services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
            services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();
            services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
            services.AddTransient<IGetAllCustomerQuery, GetAllCustomerQuery>();
            services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddTransient<IGetCustomerByDocumentNumberQuery, GetCustomerByDocumentNumberQuery>();

            // Bookings
            services.AddTransient<ICreateBookingCommand, CreateBookingCommand>();
            services.AddTransient<IGetAllBookingQuery, GetAllBookingQuery>();
            services.AddTransient<IGetBookingByDocumentNumberQuery, GetBookingByDocumentNumberQuery>();

            return services;
        }

    }
}
