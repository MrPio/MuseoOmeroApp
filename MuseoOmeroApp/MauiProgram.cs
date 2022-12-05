	using CommunityToolkit.Maui;
using Microsoft.Maui.LifecycleEvents;
using MuseoOmeroApp.api;
using MuseoOmeroApp.Pages;
using MuseoOmeroApp.View;
using MuseoOmeroApp.ViewModel;
using Sharpnado.Tabs;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace MuseoOmeroApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>().UseMauiCommunityToolkit()
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
			.UseSkiaSharp()
			.UseSharpnadoTabs(loggerEnable: false)
			.ConfigureLifecycleEvents(events =>
			{
#if ANDROID
				events.AddAndroid(android => android.OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));

				static void MakeStatusBarTranslucent(Android.App.Activity activity)
				{
					//activity.Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);
					//activity.Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
					activity.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(8, 112, 59));
					activity.Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(8, 112, 59));
				}
#endif
			}).ConfigureSyncfusionCore();

		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();

        //builder.ConfigureSyncfusionCore();
        return builder.Build();
	}
}
