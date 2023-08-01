using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using System.Collections.Concurrent;

namespace Eliseev.MauiXamlBase64ImageToolkit.Infrastructure
{
    internal sealed class Base64ImageSourceCache
    {
        public static Base64ImageSourceCache Instance = new Base64ImageSourceCache();

        private ConcurrentDictionary<string, Base64ImageSourceCacheEnty> cahce;

        public Base64ImageSourceCache()
        {
            if (cahce == null)
            {
                cahce = new ConcurrentDictionary<string, Base64ImageSourceCacheEnty>();
            }
        }

        public ImageSource GetOrCreate(string imageBase64)
        {
            if (!cahce.TryGetValue(imageBase64, out var imageSourceCacheEntry))
            {
                MemoryStream stream = new MemoryStream(Convert.FromBase64String(imageBase64));
                var imageSource = ImageSource.FromStream(() => stream);
                imageSourceCacheEntry = new Base64ImageSourceCacheEnty(imageSource);
                cahce.TryAdd(imageBase64, imageSourceCacheEntry);
            }

            imageSourceCacheEntry.IncrementReferenceCount();
            return imageSourceCacheEntry.ImageSource;
        }

        public void Remove(string imageBase64)
        {
            if (cahce.TryGetValue(imageBase64, out var imageSourceCacheEntry))
            {
                imageSourceCacheEntry.DecrementReferencesCount();

                if (imageSourceCacheEntry.HasNoReferences())
                {
                    cahce.TryRemove(imageBase64, out imageSourceCacheEntry);
                }
            }
        }
    }
}
