using Eliseev.MauiXamlBase64ImageToolkit.Infrastructure;

namespace Eliseev.MauiXamlBase64ImageToolkit
{
    /// <summary>
    /// For inject MauiXamlBase64ImageToolkit to program.
    /// </summary>
    /// <see cref="https://learn.microsoft.com/en-us/dotnet/maui/xaml/namespaces/custom-namespace-schemas"/>
    public static class Controls
    {
        /// <summary>
        /// Inject MauiXamlBase64ImageToolkit to program.
        /// For resolve error "XFC0000 Cannot resolve type"
        /// </summary>
        public static void Init(IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new NullReferenceException(nameof(serviceCollection));
            }

            serviceCollection.AddSingleton<Base64ImageSourceCache>();
        }
    }
}
