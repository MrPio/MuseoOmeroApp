using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class BigliettoView : ContentView
{
	public BigliettoView()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged(); 
        if (BindingContext == null)
            return;
        ((BigliettoViewModel)BindingContext).View = this;
    }

    public void Button_Clicked()
    {
		return;
    }
}