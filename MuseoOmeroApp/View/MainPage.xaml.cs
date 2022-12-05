using MuseoOmeroApp.api;
using MuseoOmeroApp.ViewModel;
using MuseoOmeroApp.ViewModel.Templates;
using Sharpnado.Tabs;
using Sharpnado.Tabs.Effects;
using SkiaSharp.Extended.UI.Controls;
using System.Collections.ObjectModel;

namespace MuseoOmeroApp.View;

public partial class MainPage : ContentPage
{
    public MainPageViewModel ViewModel;
    public ApiService Service;
    int _previousIndex = -1;
	public MainPage(MainPageViewModel ViewModel,ApiService service)
	{
        InitializeComponent();
        this.ViewModel = ViewModel;
        this.Service = service;
		this.BindingContext= ViewModel;
        TouchEffect.SetColor(tab1, Colors.Transparent);
        TouchEffect.SetColor(tab2, Colors.Transparent);
        TouchEffect.SetColor(tab3, Colors.Transparent);
        TouchEffect.SetColor(tab4, Colors.Transparent);
        // Carico i biglietti dal servizio
        //ViewModel.IMieiTitoliViewModel.Biglietti =
        //    new ObservableCollection<BigliettoViewModel>(service.LoadBiglietti());

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
        if (e.PropertyName == "SelectedIndex" && _previousIndex != -1)
        {
            var currentIndex = ((ViewSwitcher)sender).SelectedIndex;
            if (currentIndex == 0)
                OnIMieiTitoliAppearing();
            else
            {
                Skia.IsVisible = false;
                Skia.IsAnimationEnabled = false;

                var animation = new Animation
                {
                    {0,1,new Animation(v =>ViewModel.TopAndBottomWavesViewModel.TopWave = new GridLength(v), ViewModel.TopAndBottomWavesViewModel.TopWave.Value, 56,Easing.CubicInOut)},
                    { 0,0.5,new Animation(v => ViewModel.TopBarViewModel.RicercaOpacity = v, ViewModel.TopBarViewModel.RicercaOpacity, 0,Easing.CubicInOut )}
                };
                var c = DeviceDisplay.MainDisplayInfo;
                animation.Commit(this, "TopAnimation", 16, 850, null, null);
            }

            if (currentIndex != _previousIndex)
                ResetTopBarAndWaves();

            if (currentIndex > _previousIndex)
                TabsTransition(true);
            else if (currentIndex < _previousIndex)
                TabsTransition(false);
        }
    }

    private void OnIMieiTitoliAppearing()
    {
        Skia.IsAnimationEnabled = true;
        Skia.Source = new SKFileLottieImageSource { File = "air_ticket.json" };
        Skia.IsVisible = true;

        var animation = new Animation
        {
            {0,1,new Animation(v =>ViewModel.TopAndBottomWavesViewModel.TopWave =
            new GridLength(v), ViewModel.TopAndBottomWavesViewModel.TopWave.Value, 114,Easing.CubicInOut)},
            { 0.5,1,new Animation(v => ViewModel.TopBarViewModel.RicercaOpacity =
            v, ViewModel.TopBarViewModel.RicercaOpacity, 1,Easing.CubicInOut )}
        };
        var c = DeviceDisplay.MainDisplayInfo;
        animation.Commit(this, "TopAnimation", 16, 850, null, null);
    }
    private void ResetTopBarAndWaves()
    {
        var animation = new Animation
                {
                    {0,1,new Animation(v =>ViewModel.TopAndBottomWavesViewModel.TopWaveTranslationY = v, ViewModel.TopAndBottomWavesViewModel.TopWaveTranslationY, 0,Easing.CubicInOut)},
                    {0,1,new Animation(v =>ViewModel.TopAndBottomWavesViewModel.BottomWaveTranslationY = v, ViewModel.TopAndBottomWavesViewModel.BottomWaveTranslationY, 0,Easing.CubicInOut)},
                    {0,1,new Animation(v =>ViewModel.TopBarViewModel.TranslationY = v, ViewModel.TopBarViewModel.TranslationY, 0,Easing.CubicInOut)},
                    {0,1,new Animation(v =>ViewModel.BottomBarTranslationX = v, ViewModel.BottomBarTranslationX, 0,Easing.CubicInOut)},
                    {0,1,new Animation(v =>ViewModel.BottomBarOpacity = v, Math.Max(0,ViewModel.BottomBarOpacity), 1,Easing.CubicInOut)},
                    {0,1,new Animation(v =>ViewModel.TopBarViewModel.Opacity = v, Math.Max(0,ViewModel.TopBarViewModel.Opacity), 1,Easing.CubicInOut)},
                };
        var c = DeviceDisplay.MainDisplayInfo;
        animation.Commit(this, "ResetAnimation", 16, 850, null, null);
    }
    private void TabsTransition(bool left)
    {
        var parameters= left? new[] { 0, -DPI.WIDTH, DPI.WIDTH, 0 } : new[] {  -DPI.WIDTH,0, 0, DPI.WIDTH };
        var animation = new Animation
                {
                    {0,1,new Animation(v =>TopAndBottomWaves.TranslationX = v, parameters[0], parameters[1],Easing.CubicInOut)},
                    { 0,1,new Animation(v => TopAndBottomWaves2.TranslationX = v, parameters[2], parameters[3],Easing.CubicInOut )}
                };
        var c = DeviceDisplay.MainDisplayInfo;
        animation.Commit(this, "WavesAnimation", 16, 500, null, null);
    }
}