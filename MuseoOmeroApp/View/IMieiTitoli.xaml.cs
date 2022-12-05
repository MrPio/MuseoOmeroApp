using MuseoOmeroApp.ViewModel;

namespace MuseoOmeroApp.Pages;

public partial class IMieiTitoli : ContentView
{
	public IMieiTitoli()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        if (BindingContext is null)
            return;
        ((IMieiTitoliViewModel)BindingContext).view = this;
    }

    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        var mainPageViewModel = (MainPageViewModel)Parent.Parent.Parent.Parent.Parent.BindingContext;
        mainPageViewModel.WavesExpandFactor = e.ScrollY / 240d;
    }

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        var mainPageViewModel = (MainPageViewModel)Parent.Parent.Parent.Parent.Parent.BindingContext;
        mainPageViewModel.WavesExpandFactor = e.VerticalDelta / 240d;
    }
}