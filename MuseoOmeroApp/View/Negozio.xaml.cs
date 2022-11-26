using MuseoOmeroApp.ViewModel;

namespace MuseoOmeroApp.Pages;

public partial class Negozio : ContentPage
{
	public Negozio()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (this.AnimationIsRunning("TransitionAnimation"))
            return;
        var parentAnimation = new Animation();

        parentAnimation.Add(0, 1, new Animation(v =>
        ((NegozioViewModel)BindingContext).BigRoundedIcon.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0, 1, new Animation(v =>
        ((Grid)TopAndBottomWaves.FindByName("WavesGrid")).RowDefinitions[0] = new RowDefinition(v), 100, 64, Easing.CubicInOut));
        parentAnimation.Add(0, 1, new Animation(v =>
        ((Grid)TopAndBottomWaves.FindByName("WavesGrid")).RowDefinitions[4] = new RowDefinition(v), 34, 14, Easing.CubicInOut));
        parentAnimation.Add(0, 1, new Animation(v =>
        ((Image)TopAndBottomWaves.FindByName("BlockTop")).ScaleY = v, 1.35, 1.05, Easing.CubicInOut));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 700, null, null);
    }
    protected override async void OnDisappearing()
    {
        base.OnDisappearing();
        ((NegozioViewModel)BindingContext).BigRoundedIcon.Opacity = 0;
    }
}