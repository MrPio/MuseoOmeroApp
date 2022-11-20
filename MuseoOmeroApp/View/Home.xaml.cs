using MuseoOmeroApp.View;
using MuseoOmeroApp.ViewModel;
using SkiaSharp.Extended.UI.Controls;
using System.Diagnostics;
namespace MuseoOmeroApp.Pages;

public partial class Home : ContentPage
{
    ResourceDictionary MyColors = Application.Current.Resources.MergedDictionaries.First();

    public Home()
	{
		InitializeComponent();

        /*new Thread(() =>
        {
            Random rnd = new Random();
            while (true)
            {
                Thread.Sleep(20);
                ((HomeModelView)BindingContext).ModelEntries[1].Text =
                "a,b,c,d,e,f,g".Split(',')[rnd.Next(7)];
            }
        }).Start();*/
        
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
            return;

        var parentAnimation = new Animation();
        parentAnimation.Add(0, 1, new Animation(v => BigIconFrame.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0, 1, new Animation(v => WavesGrid.RowDefinitions[0] =new RowDefinition(v), 100, 64, Easing.CubicInOut));
        parentAnimation.Add(0, 1, new Animation(v => WavesGrid.RowDefinitions[4] =        new RowDefinition(v), 34, 14, Easing.CubicInOut));
        parentAnimation.Add(0, 1, new Animation(v => BlockTop.ScaleY =v, 1.35, 1.05, Easing.CubicInOut));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 700, null, null);

        //BigIconFrame.BackgroundColor = (Color)MyColors["Tertiary"];
        //BigIcon.TextColor = (Color)MyColors["Primary"];

        //await Task.WhenAll(
        //    BigIconFrame.ColorTo((Color)MyColors["Tertiary"], (Color)MyColors["Primary"], c => BigIconFrame.BackgroundColor = c, 600, Easing.CubicIn),
        //    BigIcon.ColorTo((Color)MyColors["Primary"], Colors.White, c => BigIcon.TextColor = c, 600,Easing.CubicIn)
        //);
    }
    protected override async void OnDisappearing()
    {
        base.OnDisappearing();
        BigIconFrame.Opacity = 0;
        WavesGrid.RowDefinitions = new RowDefinitionCollection()
        {
            new RowDefinition(100),
            new RowDefinition(GridLength.Auto),
            new RowDefinition(GridLength.Star),
            new RowDefinition(GridLength.Auto),
            new RowDefinition(34)
        };
        BlockTop.ScaleY = 1.35;
    }
}