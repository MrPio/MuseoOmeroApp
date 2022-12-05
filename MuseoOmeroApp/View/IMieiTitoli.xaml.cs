using MuseoOmeroApp.ViewModel;

namespace MuseoOmeroApp.Pages;

public partial class IMieiTitoli : ContentView
{
	public IMieiTitoli()
	{
		InitializeComponent();
	}

    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        var mainPageViewModel = (MainPageViewModel)Parent.Parent.Parent.Parent.Parent.BindingContext;
        mainPageViewModel.WavesExpandFactor = e.ScrollY / 240d;
    }
}