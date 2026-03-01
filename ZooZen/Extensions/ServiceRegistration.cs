using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZooZen.Data;
using ZooZen.Models.DbConfiguration;
using ZooZen.Services;
using ZooZen.Services.Interfaces;

namespace ZooZen.Extensions
{
    /// <summary>
    /// Регистрация на всички услуги за ZooZen чрез Dependency Injection
    /// </summary>
    public static class ServiceRegistration
    {
        public static IServiceCollection AddZooZenServices(this IServiceCollection services)
        {
            // База данни
            services.AddDbContext<ZooZenDbContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

            // Бизнес услуги
            services.AddScoped<IUserService,    UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService,   OrderService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            return services;
        }
    }
}
