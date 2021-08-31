using HotelListing.Data;
using HotelListing.IRepository;
using HotelListing.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelListing.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, 
            IConfiguration config)
        {

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(config.GetConnectionString("SqlConnection")));

            services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", buidler =>
                {
                    buidler.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
