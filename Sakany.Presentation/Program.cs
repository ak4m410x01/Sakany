using Sakany.Application.Extensions;
using Sakany.Infrastructure.Extensions;
using Sakany.Persistence.DataSeeding;
using Sakany.Persistence.Extensions;
using Sakany.Presentation.Extensions.Middlewares;
using Sakany.Presentation.Extensions.ServiceCollections;

namespace Sakany.Presentation
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            #region Create Web Application

            var builder = WebApplication.CreateBuilder(args);

            #endregion Create Web Application

            #region Clean Architecture Layers Configuration

            builder.Services.AddPresentationLayer(builder.Configuration)
                            .AddPersistenceLayer(builder.Configuration)
                            .AddApplicationLayer()
                            .AddInfrastructureLayer();

            #endregion Clean Architecture Layers Configuration

            #region Build Web Application

            var app = builder.Build();

            #endregion Build Web Application

            #region Use Middlewares

            app.UsePresentationMiddlewares();

            #endregion Use Middlewares

            app.MapControllers();

            #region Data Seeding

            await DataSeeding.Initialize(app.Services.CreateAsyncScope().ServiceProvider);

            #endregion Data Seeding

            #region Run Web Application

            app.Run();

            #endregion Run Web Application
        }
    }
}