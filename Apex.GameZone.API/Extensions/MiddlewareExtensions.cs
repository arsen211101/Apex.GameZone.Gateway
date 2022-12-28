using Apex.GameZone.API.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Apex.GameZone.API.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandling(this IApplicationBuilder app)
        {
            app.UseMiddleware<CustomExceptionHandlingMiddleware>();

            return app;
        }
    }
}
