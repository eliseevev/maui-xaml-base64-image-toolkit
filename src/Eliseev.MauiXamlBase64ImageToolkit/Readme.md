Very simple package to use base64 image in maui-xaml app.
If you need to use a base64 image and don't want to have infrastructure code in your business logic, this package is for you.

To use - first initialize the package in your code (for have a link from the application to the library)

```

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        ...
        Eliseev.MauiXamlBase64ImageToolkit.Controls.Init();
    }
}

```

You can then use base64 images in your code:
   - add namespace to your xaml file `xmlns:base64Controls="http://eliseev/base64Image"`
   - use ImageBase64 base `<base64Controls:ImageBase64 Base64Source={binding youBase64String}/>`


For example:

```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:base64Controls="http://eliseev/base64Image"
             x:Class="YourNameSpace.SomePage">
    <vertical stack layout>
        <base64Controls:ImageBase64
            Height request = "200"
            Base64Source="{binding youBase64String}"/>
    </vertical stack layout>
</ContentPage>

```
** ImageBase64 is a version of Image, so it has all of its functionality.