using MrGimme.api;

namespace MrGimme;

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
            });
        return builder.Build();
	}
}
