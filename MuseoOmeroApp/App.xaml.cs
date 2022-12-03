#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif
using MuseoOmeroApp.Pages;
using MuseoOmeroApp.View;
using MuseoOmeroApp.ViewModel;

namespace MuseoOmeroApp;

public partial class App : Application
{
    const int WindowWidth = 500;
    const int WindowHeight = 900;
    public App()
    {
        InitializeComponent();

        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
#endif
        });

        MainPage = new MainPage(new MainPageViewModel());
        DPI.mainPage = MainPage;
        return;

        //TODO API
        if (Preferences.ContainsKey("access_token"))
        {
            MainPage = new TabbedHome();
        }
        else
        {
            MainPage = new LoginPage();
        }
	}
}
