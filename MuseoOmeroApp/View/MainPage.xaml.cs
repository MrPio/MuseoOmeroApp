using MuseoOmeroApp.ViewModel;
using Sharpnado.Tabs;
using Sharpnado.Tabs.Effects;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Input;

namespace MuseoOmeroApp.View;

public partial class MainPage : ContentPage
{
	int _previousIndex = -1;
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
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

			if (((ViewSwitcher)sender).SelectedIndex > _previousIndex)
			{
                // <---
                var animation = new Animation
                {
                    {0,1,new Animation(v =>TopAndBottomWaves.TranslationX = v, 0, -DPI.WIDTH,Easing.CubicInOut)},
                    { 0,1,new Animation(v => TopAndBottomWaves2.TranslationX = v, DPI.WIDTH, 0,Easing.CubicInOut )}
                };

                animation.Commit(this, "WavesAnimation", 16, 500, null, null);
            }
            else if (((ViewSwitcher)sender).SelectedIndex < _previousIndex)
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