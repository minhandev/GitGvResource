using Data.BaseRepository;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.Utilities
{
    public static partial class Common
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, string connectionString, string Project)
        {
            services.AddDbContext<GvResourceContext>(options => options.UseSqlServer(connectionString, x => x.MigrationsAssembly(Project)));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }

        public static string GetNameProject()
        {
            return System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
        }
    }
}
