using MuseoOmeroApp.ViewModel;
using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

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
        Icon.TextColor = DPI.COL_2;
        Border.Stroke = DPI.COL_2;
        Border.StrokeThickness = ((RoundedEntryViewModel)BindingContext).BorderTicknessFocused;
        Border.BackgroundColor = Colors.White;
    }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#686868");
        Icon.TextColor = ((RoundedEntryViewModel)BindingContext).EntryBorderColor;
        Border.Stroke = ((RoundedEntryViewModel)BindingContext).EntryBorderColor;
        Border.StrokeThickness = ((RoundedEntryViewModel)BindingContext).BorderTicknessUnfocused;
        Border.BackgroundColor = Colors.White;
    }
}