using Microsoft.AspNetCore.Builder;

namespace AuthenticationService
{
    public static class LogMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogMiddelware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
