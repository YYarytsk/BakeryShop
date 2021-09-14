﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryShop.DataAccess.Interfaces;
using BakeryShop.Domain.Implementation;
using BakeryShop.Domain.Interfaces;
using BakeryShop.WebApp.Helpers;
using BakeryShop.WebApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BakeryShop.WebApp.Configuration
{
    public class ConfigureDependencies
    {
        //dependency injection for DOMAIN
        public static void AddServices(IServiceCollection services)
        {
            
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<ICatalogService, CatalogService>();
            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IFileHelper, FileHelper>();

        }
    }
}
