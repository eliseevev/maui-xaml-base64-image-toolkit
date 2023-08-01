using Eliseev.MauiXamlBase64ImageToolkit.Infrastructure;
using System.ComponentModel;

namespace Eliseev.MauiXamlBase64ImageToolkit
{
    public class ImageBase64 : Microsoft.Maui.Controls.Image
    {
        private string base64;

        public static readonly BindableProperty Base64SourceProperty =
            BindableProperty.Create(
                nameof(Base64Source),
                typeof(string),
                typeof(ImageBase64),
                string.Empty,
                propertyChanged: OnBase64SourceChanged);

        public string Base64Source
        {
            set
            {
                SetValue(Base64SourceProperty, value);
            }
            get
            {
                return (string)GetValue(Base64SourceProperty);
            }
        }

        static void OnBase64SourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var imageSource = Base64ImageSourceCache.Instance.GetOrCreate((string)newValue);
            ((ImageBase64)bindable).base64 = (string)newValue;
            ((Image)bindable).Source = imageSource;
        }

        ~ImageBase64()
        {
            Base64ImageSourceCache.Instance.Remove(base64);
        }
    }
}