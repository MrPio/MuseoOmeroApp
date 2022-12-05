using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class Biglietto : ContentView
{
	public Biglietto()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        ((BigliettoViewModel)BindingContext!).View = this;
    }

    public void Button_Clicked()
    {
		return;
    }
}