using Microsoft.Extensions.Logging;

namespace MauiXamlBase64ImageToolkitExample
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


            Eliseev.MauiXamlBase64ImageToolkit.Controls.Init(builder.Services);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}