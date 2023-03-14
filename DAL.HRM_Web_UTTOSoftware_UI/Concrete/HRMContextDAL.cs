
using DAL.HRM_Web_UTTOSoftware.Abstract;
using DAL.HRM_Web_UTTOSoftware.Concrete.Context;
using DAL.HRM_Web_UTTOSoftware.Concrete.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ANK_9.DAL.Concrete
{
    public static class HRMContextDAL
    {
        public static void AddScoppedDAL(this IServiceCollection services)
        {
            services.AddDbContext<HRMContextDB>()
                    .AddScoped<IPersonDAL, PersonRepository>();
        }
    }
}
