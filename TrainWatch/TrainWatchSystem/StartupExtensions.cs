using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrainWatchSystem.BLL;
using TrainWatchSystem.DAL;

namespace TrainWatchSystem
{
    public static class StartupExtensions
    {
        public static void AddBackendDependencies(
            this IServiceCollection services,
            Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<TrainWatchContext>(options);

            services.AddTransient<TrainWatchServices>(serviceProvider => {
                var context = serviceProvider.GetRequiredService<TrainWatchContext>();
                return new TrainWatchServices(context);
            });

        }
    }
}