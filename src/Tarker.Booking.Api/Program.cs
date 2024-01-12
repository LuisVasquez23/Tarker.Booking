using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Api;
using Tarker.Booking.Application;
using Tarker.Booking.Application.DatatBase.Customer.Commands.CreateCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Commands.DeleteCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Commands.UpdateCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetAllCustomer;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerByDocumentNumber;
using Tarker.Booking.Application.DatatBase.Customer.Queries.GetCustomerById;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddWebApi()
        .AddCommon()
        .AddApplication()
        .AddExternal(builder.Configuration)
        .AddPersistence(builder.Configuration);

var app = builder.Build();

app.MapPost("/testService" , async (IGetCustomerByIdQuery service) =>
{

    return await service.Execute(1);

});

app.Run();
