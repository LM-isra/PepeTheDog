using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PepeTheDog.Data;
using PepeTheDog.Core.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using AutoMapper;

namespace PepeTheDog.Api.Root
{
    public class CompositionRoot
    {
        public CompositionRoot() { }

        public static void InjectDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataProtection();
            
            services.AddDbContext<AppDbContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"), x => x.MigrationsAssembly("PepeTheDog.Data"));
            });

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Pepe The Dog", Version = "v1" });
            });

            services.AddAutoMapper(typeof(Startup));

        }
    }
}