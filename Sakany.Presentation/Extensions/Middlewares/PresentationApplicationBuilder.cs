﻿using Sakany.Presentation.Extensions.Middlewares.Authentication;
using Sakany.Presentation.Extensions.Middlewares.Authorization;
using Sakany.Presentation.Extensions.Middlewares.Cors;
using Sakany.Presentation.Extensions.Middlewares.Exceptions;
using Sakany.Presentation.Extensions.Middlewares.StaticFiles;
using Sakany.Presentation.Extensions.Middlewares.Swagger;

namespace Sakany.Presentation.Extensions.Middlewares
{
    public static class PresentationApplicationBuilder
    {
        public static IApplicationBuilder UsePresentationMiddlewares(this IApplicationBuilder app)
        {
            app.UseGlobalExceptionMiddlewares();

            app.UseExeptionHandlerMiddlewares();

            app.UseStatusCodePagesWithReExecute("/Api/V1/Errors/{0}");

            app.UseCorsMiddlewares();

            app.UseSwaggerMiddlewares();

            app.UseStaticFilesMiddlewares();

            app.UseAuthenticationMiddlewares();

            app.UseAuthorizationMiddlewares();

            return app;
        }
    }
}