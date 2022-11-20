using MuseoOmeroApp.ViewModel;

namespace MuseoOmeroApp.Templates;

public partial class RoundedEntry : ContentView
{
    ResourceDictionary MyColors = Application.Current.Resources.MergedDictionaries.First();
    public RoundedEntry()
	{
		InitializeComponent();
	}

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#1e1e1e");
        Icon.TextColor = (Color)MyColors["Primary"];
        Border.Stroke = (Color)MyColors["Primary"];
        Border.StrokeThickness = 2.6;
        Border.BackgroundColor = Colors.White;

    }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#686868");
        Icon.TextColor = Color.FromHex("#c8c8c8");
        Border.Stroke = Color.FromHex("#c8c8c8");
        Border.StrokeThickness = 1;
        Border.BackgroundColor = Colors.White;
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        HomeModelView.OnTextChanged(sender, e);
    }
}