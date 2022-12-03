using MuseoOmeroApp.View;
using MuseoOmeroApp.ViewModel;

namespace MuseoOmeroApp.Pages;

public partial class Home : ContentView
{
    ResourceDictionary MyColors = Application.Current.Resources.MergedDictionaries.First();

    public Home()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
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

    //protected override async void OnAppearing()
    //{
    //    base.OnAppearing();

    //    if (this.AnimationIsRunning("TransitionAnimation"))
    //        return;

    //    var parentAnimation = new Animation();

    //    parentAnimation.Add(0, 1, new Animation(v =>
    //    ((HomeViewModel)BindingContext).BigRoundedIcon.Opacity = v, 0, 1, Easing.CubicIn));


    //    parentAnimation.Add(0, 1, new Animation(v =>
    //    ((Grid)TopAndBottomWaves.FindByName("WavesGrid")).RowDefinitions[0] = new RowDefinition(v), 100, 64, Easing.CubicInOut));

    //    parentAnimation.Add(0, 1, new Animation(v =>
    //    ((Grid)TopAndBottomWaves.FindByName("WavesGrid")).RowDefinitions[4] = new RowDefinition(v), 34, 14, Easing.CubicInOut));

    //    parentAnimation.Add(0, 1, new Animation(v =>
    //    ((Image)TopAndBottomWaves.FindByName("BlockTop")).ScaleY = v, 1.35, 1.05, Easing.CubicInOut));

    //    parentAnimation.Commit(this, "TransitionAnimation", 16, 700, null, null);

    //    BigIconFrame.BackgroundColor = (Color)MyColors["Tertiary"];
    //    BigIcon.TextColor = (Color)MyColors["Primary"];

    //    await Task.WhenAll(
    //        BigIconFrame.ColorTo((Color)MyColors["Tertiary"], (Color)MyColors["Primary"], c => BigIconFrame.BackgroundColor = c, 600, Easing.CubicIn),
    //        BigIcon.ColorTo((Color)MyColors["Primary"], Colors.White, c => BigIcon.TextColor = c, 600, Easing.CubicIn)
    //    );
    //}
    //protected override async void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //    ((HomeViewModel)BindingContext).BigRoundedIcon.Opacity = 0;
    //    WavesGrid.RowDefinitions = new RowDefinitionCollection()
    //    {
    //        new RowDefinition(100),
    //        new RowDefinition(GridLength.Auto),
    //        new RowDefinition(GridLength.Star),
    //        new RowDefinition(GridLength.Auto),
    //        new RowDefinition(34)
    //    };
    //    BlockTop.ScaleY = 1.35;
    //}

    private void DatePicker_Focused(object sender, FocusEventArgs e)
    {
        ((DatePicker)sender).TextColor = Color.FromHex("#1e1e1e");
        BirthDateIcon.TextColor = (Color)MyColors["Primary"];
        BirthDateBorder.Stroke = (Color)MyColors["Primary"];
        BirthDateBorder.StrokeThickness = 2.6;
        BirthDateBorder.BackgroundColor = Colors.White;
    }

    private void DatePicker_Unfocused(object sender, FocusEventArgs e)
    {
        ((DatePicker)sender).TextColor = Color.FromHex("#686868");
        BirthDateIcon.TextColor = Color.FromHex("#c8c8c8");
        BirthDateBorder.Stroke = Color.FromHex("#c8c8c8");
        BirthDateBorder.StrokeThickness = 1;
        BirthDateBorder.BackgroundColor = Colors.White;
    }

    private void SessoPicker_Focused(object sender, FocusEventArgs e)
    {
        ((Picker)sender).TextColor = Color.FromHex("#1e1e1e");
        SessoIcon.TextColor = (Color)MyColors["Primary"];
        SessoBorder.Stroke = (Color)MyColors["Primary"];
        SessoBorder.StrokeThickness = 2.6;
        SessoBorder.BackgroundColor = Colors.White;
    }

    private void SessoPicker_Unfocused(object sender, FocusEventArgs e)
    {
        ((Picker)sender).TextColor = Color.FromHex("#686868");
        SessoIcon.TextColor = Color.FromHex("#c8c8c8");
        SessoBorder.Stroke = Color.FromHex("#c8c8c8");
        SessoBorder.StrokeThickness = 1;
        SessoBorder.BackgroundColor = Colors.White;
    }

    private void ProvenienzaEntry_Focused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#1e1e1e");
        ProvenienzaIcon.TextColor = (Color)MyColors["Primary"];
        ProvenienzaBorder.Stroke = (Color)MyColors["Primary"];
        ProvenienzaBorder.StrokeThickness = 2.6;
        ProvenienzaBorder.BackgroundColor = Colors.White;
    }

    private void ProvenienzaEntry_Unfocused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#686868");
        ProvenienzaIcon.TextColor = Color.FromHex("#c8c8c8");
        ProvenienzaBorder.Stroke = Color.FromHex("#c8c8c8");
        ProvenienzaBorder.StrokeThickness = 1;
        ProvenienzaBorder.BackgroundColor = Colors.White;
    }

    //private void ContentView_BindingContextChanged(object sender, EventArgs e)
    //{
    //    BindingContext??=new HomeViewModel();
    //}

    //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    //{
    //    if (await DisplayAlert("Vuoi davvero uscire?", "Dovrai eseguire  di nuovo il login per rientrare.", "Yes", "No"))
    //    {
    //        Preferences.Clear("username");
    //        Preferences.Clear("access_token");
    //        Application.Current.MainPage = new RegisterPage();
    //    }
    //}

}