using FluentValidation;
using FluentValidation.AspNetCore;
using Lareen_Cafe.VerticalSlicing.Common;
using LareenCafe.Api.VerticalSlicing.Data.Context;
using LareenCafe.Api.VerticalSlicing.Data.Repository.Interface;
using LareenCafe.Api.VerticalSlicing.Data.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace LareenCafe.Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddMediatRServices();
            services.AddEndpointsApiExplorer();
            //AddSwaggerServices
            services.AddSwaggerGen()
                    .AddFluentValidationConfig();

            //services.AddHttpContextAccessor();

            // services.AddAuthConfig(configuration);

            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                .EnableSensitiveDataLogging();
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<RequestParameters>();
            services.AddScoped<ControllerParameters>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        private static IServiceCollection AddFluentValidationConfig(this IServiceCollection services)
        {
            services
                .AddFluentValidationAutoValidation()
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
        private static IServiceCollection AddMediatRServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

            return services;
        }


    }
}
