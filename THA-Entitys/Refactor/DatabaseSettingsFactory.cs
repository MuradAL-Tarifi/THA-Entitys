using Microsoft.EntityFrameworkCore;
using THA_Entitys.Models;

namespace THA_Entitys.Refactor
{
    public static class DatabaseSettingsFactory
    {

        public static void DatabaseSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AlumniadbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }

    }
}
