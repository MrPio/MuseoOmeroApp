using MrGimme.api;
using Newtonsoft.Json;

namespace MrGimme.Pages;

public partial class LoginPage : ContentPage
{
    static ApiService api=new ApiService();
	public LoginPage()
	{
        InitializeComponent();
    }
    bool loginInProgress=false;
    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (loginInProgress)
        {
            return;
        }
        loginInProgress = true;
        var campiCompilati = true;
        if (UsernameEntry.Text is "" or null)
        {
            UsernameBorder.BackgroundColor = Color.FromHex("#09713c");
            campiCompilati=false;
        }
        if (PasswordEntry.Text is "" or null)
        {
            PasswordBorder.BackgroundColor = Color.FromHex("#09713c");
            campiCompilati=false;
        }

        if (!campiCompilati)
        {
            await DisplayAlert("Attenzione", "Compila correttamente tutti i campi!", "OK");
            loginInProgress=false;
            return;
        }

        Loading.IsVisible = true; 
        var response =await api.Login(UsernameEntry.Text, PasswordEntry.Text);
        Loading.IsVisible = false;
        if (response is null)
        {
            await DisplayAlert("Errore", "Il server non riesce a processare la richiesta.", "OK");
        }
        else
        {
            await DisplayAlert("Successo!", JsonConvert.SerializeObject(response), "OK");
        }
        loginInProgress = false;
    }

    private void LoginButton_Pressed(object sender, EventArgs e)
    {
        ((Button)sender).BackgroundColor = Color.FromHex("#FFFFFF");
        ((Button)sender).TextColor = Color.FromHex("#09713c");
        ((Button)sender).BorderWidth = 4;
    }

    private void LoginButton_Released(object sender, EventArgs e)
    {
        ((Button)sender).BackgroundColor = Color.FromHex("#09713c");
        ((Button)sender).TextColor = Color.FromHex("#FFFFFF");
        ((Button)sender).BorderWidth = 0;
    }

    private void UsernameEntry_Focused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#1e1e1e");
        UsernameIcon.Source = "account_on.png";
        UsernameBorder.Stroke = Color.FromHex("#09713c");
        UsernameBorder.StrokeThickness = 2.6;
        UsernameBorder.BackgroundColor = Colors.White;

    }

    private void UsernameEntry_Unfocused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#686868");
        UsernameIcon.Source = "account.png";
        UsernameBorder.Stroke = Color.FromHex("#c8c8c8");
        UsernameBorder.StrokeThickness = 1;
        UsernameBorder.BackgroundColor = Colors.White;

    }

    private void PasswordEntry_Focused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#1e1e1e");
        PasswordIcon.Source = "shield_on.png";
        PasswordBorder.Stroke = Color.FromHex("#09713c");
        PasswordBorder.StrokeThickness = 2.6;
        PasswordBorder.BackgroundColor = Colors.White;
    }   

    private void PasswordEntry_Unfocused(object sender, FocusEventArgs e)
    {
        ((Entry)sender).TextColor = Color.FromHex("#686868");
        PasswordIcon.Source = "shield.png";
        PasswordBorder.Stroke = Color.FromHex("#c8c8c8");
        PasswordBorder.StrokeThickness = 1;
        PasswordBorder.BackgroundColor = Colors.White;

    }
}