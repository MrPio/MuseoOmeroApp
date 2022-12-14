using MuseoOmeroApp.Pages;

namespace MuseoOmeroApp.View.Templates;

public partial class TopBar : ContentView
{
	public TopBar()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        if (await Application.Current.MainPage.DisplayAlert("Vuoi davvero uscire?", "Dovrai eseguire  di nuovo il login per rientrare.", "Yes", "No"))
        {
            Preferences.Remove("username");
            Preferences.Remove("access_token");
            Application.Current.MainPage = new LoginPage();
        }
    }
}