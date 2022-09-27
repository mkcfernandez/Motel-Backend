using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Motel.Application.Contracts;
using Motel.Application.Contracts.Infrastructure;
using Motel.Application.Contracts.Persistence;
using Motel.Application.Models;
using Motel.Infrastructure.Email;
using Motel.Infrastructure.Persistence;
using Motel.Infrastructure.Repositories;

namespace Motel.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MotelDbContext>(option =>
                option.UseSqlServer(configuration.GetConnectionString("DB")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            services.AddScoped<IMovimientoHabitacionRepository, MovimietnoHabitacionRepository>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
