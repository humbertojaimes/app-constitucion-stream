using MexicanConstitution.Mobile.Interfaces;
using MexicanConstitution.Mobile.Services;
using MexicanConstitution.Mobile.Views;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MexicanConstitution.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseSkiaSharp()  //Luego de agregar el Nugget de Skia agregar esta linea para poder usarlo
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        //.NET 8 si requiere registrar las páginas
        //builder.Services.AddSingleton<ArticlesPage>();
        builder.Services.AddSingleton<ArticlesViewModel>();
        builder.Services.AddSingleton<IConstitutionDataService, ConstitutionJsonService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}