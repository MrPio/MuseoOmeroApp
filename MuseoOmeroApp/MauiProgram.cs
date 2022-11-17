using MuseoOmeroApp.api;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace MuseoOmeroApp;

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

                fonts.AddFont("Lato-Regular.ttf", "Lato");
                fonts.AddFont("Lato-Italic.ttf", "LatoItalic");
                fonts.AddFont("Lato-Light.ttf", "LatoLight");
                fonts.AddFont("Lato-LightItalic.ttf", "LatoLightItalic");

                fonts.AddFont(filename: "materialdesignicons-webfont.ttf", alias: "MaterialDesignIcons");
            })
			.UseSkiaSharp();	
		builder.ConfigureSyncfusionCore();
        return builder.Build();
	}
}
