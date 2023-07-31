using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace MauiXamlBase64ImageToolkit.Example
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}