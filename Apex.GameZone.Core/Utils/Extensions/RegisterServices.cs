using Apex.GameZone.Core.Services.Common;
using Apex.GameZone.Core.Services.GameZone;
using Apex.GameZone.Data.Repositories.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Apex.GameZone.Core.Utils.Extensions
{
    public static class ServiceRegisterer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region Services
                services.AddScoped<IGameZoneService, GameZoneService>();
                services.AddScoped<ISectionService, SectionService>();
                services.AddScoped<IProductService, ProductService>();
            #endregion
        }
    }
}