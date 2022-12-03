using MuseoOmeroApp.ViewModel;
using Sharpnado.Tabs;
using Sharpnado.Tabs.Effects;
using SkiaSharp.Extended.UI.Controls;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Input;

namespace MuseoOmeroApp.View;

public partial class MainPage : ContentPage
{
    MainPageViewModel viewModel;
    int _previousIndex = -1;
	public MainPage(MainPageViewModel viewModel)
	{
        InitializeComponent();
        this.viewModel = viewModel;
		this.BindingContext= viewModel;
        TouchEffect.SetColor(tab1, Colors.Transparent);
        TouchEffect.SetColor(tab2, Colors.Transparent);
        TouchEffect.SetColor(tab3, Colors.Transparent);
        TouchEffect.SetColor(tab4, Colors.Transparent);
    }

    private void Switcher_PropertyChanging(object sender, PropertyChangingEventArgs e)
    {
		if (e.PropertyName== "SelectedIndex")
		{
			_previousIndex = ((ViewSwitcher)sender).SelectedIndex;
        }
    }

	private void Switcher_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
	{
		if (e.PropertyName == "SelectedIndex" && _previousIndex!=-1)
		{
            var currentIndex = ((ViewSwitcher)sender).SelectedIndex;
            if (currentIndex == 1)
            {
                Skia.IsAnimationEnabled = true;
                Skia.Source = new SKFileLottieImageSource { File="air_ticket.json" };
                Skia.IsVisible = true;

                var animation = new Animation
                {
                    {0,1,new Animation(v =>viewModel.TopAndBottomWavesViewModel.TopWave = new GridLength(v), viewModel.TopAndBottomWavesViewModel.TopWave.Value, 110,Easing.CubicInOut)},
                    { 0.5,1,new Animation(v => viewModel.TopBarViewModel.RicercaOpacity = v, viewModel.TopBarViewModel.RicercaOpacity, 1,Easing.CubicInOut )}
                };
                var c = DeviceDisplay.MainDisplayInfo;
                animation.Commit(this, "TopAnimation", 16, 850, null, null);
            }
            else
            {
                Skia.IsVisible = false;
                Skia.IsAnimationEnabled = false;

                var animation = new Animation
                {
                    {0,1,new Animation(v =>viewModel.TopAndBottomWavesViewModel.TopWave = new GridLength(v), viewModel.TopAndBottomWavesViewModel.TopWave.Value, 56,Easing.CubicInOut)},
                    { 0,0.5,new Animation(v => viewModel.TopBarViewModel.RicercaOpacity = v, viewModel.TopBarViewModel.RicercaOpacity, 0,Easing.CubicInOut )}
                };
                var c = DeviceDisplay.MainDisplayInfo;
                animation.Commit(this, "TopAnimation", 16, 850, null, null);
            }

            if (currentIndex > _previousIndex)
			{
                // <---
                var animation = new Animation
                {
                    {0,1,new Animation(v =>TopAndBottomWaves.TranslationX = v, 0, -DPI.WIDTH,Easing.CubicInOut)},
                    { 0,1,new Animation(v => TopAndBottomWaves2.TranslationX = v, DPI.WIDTH, 0,Easing.CubicInOut )}
                };
                var c = DeviceDisplay.MainDisplayInfo;
                animation.Commit(this, "WavesAnimation", 16, 500, null, null);
            }
            else if (currentIndex < _previousIndex)
			{
                // --->
                var animation = new Animation
                {
                    {0,1,new Animation(v =>TopAndBottomWaves.TranslationX = v, -DPI.WIDTH, 0,Easing.CubicInOut)},
                    { 0,1,new Animation(v => TopAndBottomWaves2.TranslationX = v, 0, DPI.WIDTH ,Easing.CubicInOut)}
                };

                animation.Commit(this, "WavesAnimation", 16, 500, null, null);
            }
		}
	}
}