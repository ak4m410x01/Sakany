using Sakany.Presentation.Extensions.Middlewares.Authentication;
using Sakany.Presentation.Extensions.Middlewares.Authorization;
using Sakany.Presentation.Extensions.Middlewares.Cors;
using Sakany.Presentation.Extensions.Middlewares.Swagger;

namespace Sakany.Presentation.Extensions.Middlewares
{
    public static class PresentationApplicationBuilder
    {
        public static IApplicationBuilder UsePresentationMiddlewares(this IApplicationBuilder app)
        {
            app.UseCorsMiddlewares();

            app.UseSwaggerMiddlewares();

            app.UseAuthenticationMiddlewares();

            app.UseAuthorizationMiddlewares();

            return app;
        }
    }
}