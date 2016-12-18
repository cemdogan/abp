﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore
{
    public class AbpAspNetCoreModule : IAbpModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            AddAspNetServices(services);

            services.AddObjectAccessor<IApplicationBuilder>();
            services.AddAssemblyOf<AbpAspNetCoreModule>();
        }

        private static void AddAspNetServices(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}