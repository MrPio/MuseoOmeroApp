using MuseoOmeroApp.ViewModel;
using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class RoundedEntry : ContentView
{
    ResourceDictionary MyColors = Application.Current.Resources.MergedDictionaries.First();
    RoundedEntryViewModel viewModel;
    public RoundedEntry()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        viewModel = (RoundedEntryViewModel)BindingContext;
    }

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#1e1e1e");
        Icon.TextColor = DPI.COL_2;
        Border.Stroke = DPI.COL_2;
        Border.StrokeThickness = viewModel.BorderTicknessFocused;
        Border.BackgroundColor = Colors.White;
    }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#686868");
        Icon.TextColor = viewModel.EntryBorderColor;
        Border.Stroke = viewModel.EntryBorderColor;
        Border.StrokeThickness = viewModel.BorderTicknessUnfocused;
        Border.BackgroundColor = Colors.White;
    }

    private void DatePicker_Focused(object sender, FocusEventArgs e)
    {
        ((DatePicker)sender).TextColor = Color.FromHex("#1e1e1e");
        Icon.TextColor = DPI.COL_2;
        Border.Stroke = DPI.COL_2;
        Border.StrokeThickness = viewModel.BorderTicknessFocused;
        Border.BackgroundColor = Colors.White;
    }

    private void DatePicker_Unfocused(object sender, FocusEventArgs e)
    {
        ((DatePicker)sender).TextColor = Color.FromHex("#686868");
        Icon.TextColor = viewModel.EntryBorderColor;
        Border.Stroke = viewModel.EntryBorderColor;
        Border.StrokeThickness = viewModel.BorderTicknessUnfocused;
        Border.BackgroundColor = Colors.White;
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {

    }
}