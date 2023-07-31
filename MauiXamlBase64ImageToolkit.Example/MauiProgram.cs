﻿using Microsoft.Extensions.Logging;

namespace MauiXamlBase64ImageToolkit.Example
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Eliseev.MauiXamlBase64ImageToolkit.Controls.Init();

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

            return builder.Build();
        }
    }
}