using CommunityToolkit.Maui;
using GameStore.HybridApp.Services;
using Microsoft.Extensions.Logging;
using RazorClassLibrary.Components.Services;

namespace GameStore.HybridApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
#endif
            builder.Services.AddHttpClient<IGameStoreService, GameStoreService>();
            builder.Services.AddHttpClient<IGenreService, GenreService>();

            return builder.Build();
        }
    }
}
