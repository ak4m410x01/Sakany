using Sakany.Presentation.Middlewares;

namespace Sakany.Presentation.Extensions.Middlewares.Exceptions
{
    public static class ExeptionHandlerApplicationBuilder
    {
        public static IApplicationBuilder UseExeptionHandlerMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
            return app;
        }
    }
}