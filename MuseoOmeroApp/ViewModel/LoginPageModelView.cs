#if ANDROID
using Android.OS;
using MuseoOmeroApp;
using MuseoOmeroApp.ViewModel;
using MuseoOmeroApp.ViewModel;
using MuseoOmeroApp.ViewModel.Templates;
#endif

using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel
{
    public class LoginPageModelView
    {
        public static double DensityFactor { get; } = 2.75 / DeviceDisplay.MainDisplayInfo.Density;

        public RowDefinitionCollection CenterScreenGrid
        { get; set; } = new()
        {
            #if ANDROID
            new RowDefinition { Height = 70 * DensityFactor },
            new RowDefinition { Height = GridLength.Star },
            new RowDefinition { Height = 70 * DensityFactor }
            #else
            new RowDefinition { Height = 80 },
            new RowDefinition { Height = GridLength.Star },
            new RowDefinition { Height = 120 }
            #endif
        };

        public RowDefinitionCollection WavesGrid
        { get; set; } = new()
        {
            #if ANDROID
            new RowDefinition { Height = 46 * DensityFactor },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Star },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = 46 * DensityFactor }
            #else
            new RowDefinition { Height = 50 },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Star },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = 100 }
            #endif
        };

        public Thickness ContentMargin
#if ANDROID

        { get; set; } = new(32 * DensityFactor, 0, 32 * DensityFactor, 0);
#else
        { get; set; } = new(32, 0, 32, 0);

#endif

    }
}
