using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class NegozioItem : ContentView
{
	public NegozioItem()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
		((NegozioItemViewModel)BindingContext).Preferred = !((NegozioItemViewModel)BindingContext).Preferred;
    }
}