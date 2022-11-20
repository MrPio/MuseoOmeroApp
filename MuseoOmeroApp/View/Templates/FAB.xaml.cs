using MuseoOmeroApp.ViewModel.Templates;

namespace MuseoOmeroApp.View.Templates;

public partial class FAB : ResourceDictionary
{
    ResourceDictionary MyColors = Application.Current.Resources.MergedDictionaries.First();

    public FAB()
	{
		InitializeComponent();
	}


    private void Button_Pressed(object sender, EventArgs e)
    {
        ((Button)sender).BackgroundColor = Colors.White;
        ((Button)sender).TextColor = (Color)MyColors["Primary"];

        ((Button)sender).BorderWidth = 3;
        ((Button)sender).BorderColor = (Color)MyColors["Primary"];
    }

    private void Button_Released(object sender, EventArgs e)
    {
        ((Button)sender).BackgroundColor = (Color)MyColors["Primary"];
        
        ((Button)sender).TextColor = (Color)MyColors["Tertiary"];
    }
}