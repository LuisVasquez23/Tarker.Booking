﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Persistence.DataBase;

namespace Tarker.Booking.Persistence
{
    public static class DependencyInjectionService
    {

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseService>(options =>
            options.UseSqlServer(configuration.GetConnectionString("devConnection")));

            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }

    }
}
