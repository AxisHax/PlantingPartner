using Microsoft.Extensions.Logging;
using Planting_Partner.Services;
/*
*
*  This is the entry point for the app.
*
*/
namespace Planting_Partner
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<PlantService>();

            builder.Services.AddSingleton<PlantsViewModel>();

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}