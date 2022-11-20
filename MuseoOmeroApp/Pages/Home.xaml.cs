using MuseoOmeroApp.ModelView;
using MuseoOmeroApp.ViewModel;
using SkiaSharp.Extended.UI.Controls;
using System.Diagnostics;

namespace MuseoOmeroApp.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

        new Thread(() =>
        {
            Random rnd = new Random();
            while (true)
            {
                Thread.Sleep(20);
                ((HomeModelView)BindingContext).ModelEntries[1].Text =
                "a,b,c,d,e,f,g".Split(',')[rnd.Next(7)];
            }
        }).Start();
        
    }
}