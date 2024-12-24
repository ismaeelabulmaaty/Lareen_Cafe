using FluentValidation;
using FluentValidation.AspNetCore;
using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Features.Account.Common.Helper;
using LareenCafe.Api.VerticalSlicing.Data.Context;
using LareenCafe.Api.VerticalSlicing.Data.Repository.Interface;
using LareenCafe.Api.VerticalSlicing.Data.Repository.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.Reflection;
using System.Text;

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

            services.AddHttpContextAccessor();

             services.AddAuthConfig(configuration);

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

        private static IServiceCollection AddAuthConfig(this IServiceCollection services,
       IConfiguration configuration)
        {
            services.AddOptions<JwtOptions>()
                    .BindConfiguration(JwtOptions.SectionName)
                    .ValidateDataAnnotations()
                    .ValidateOnStart();

            var jwtSettings = configuration.GetSection(JwtOptions.SectionName).Get<JwtOptions>();

            services.AddAuthentication(opts =>
            {
                opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
              .AddJwtBearer(options =>
              {
                  options.SaveToken = true;
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      ValidateIssuer = true,
                      ValidateAudience = true,
                      ValidateLifetime = true,
                      ValidateIssuerSigningKey = true,
                      ValidIssuer = jwtSettings?.Issuer,
                      ValidAudience = jwtSettings?.Audience,
                      IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings?.Key!)),
                      ClockSkew = TimeSpan.Zero
                  };
              });

            return services;
        }



    }
}
