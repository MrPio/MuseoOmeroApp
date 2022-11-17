using MuseoOmeroApp.ModelView;
using SkiaSharp.Extended.UI.Controls;
using System.Diagnostics;

namespace MuseoOmeroApp.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        BindingContext = new HomeModelView();

    }

    private void SKLottieView_PropertyChanging(object sender, PropertyChangingEventArgs e)
    {
    }
}