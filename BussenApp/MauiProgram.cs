using BussenApp.Pages;
using Maui.Plugins.PageResolver;
using MauiIcons.Material.Rounded;
using Microsoft.Extensions.Logging;

namespace BussenApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UsePageResolver()
                .UseMaterialRoundedMauiIcons()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<PlayersPage>();

            builder.Services.UsePageResolver();

            return builder.Build();
        }
    }
}
