using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel
{
    class DPI
    {

        private static ResourceDictionary MyColors = Application.Current.Resources.MergedDictionaries.First();
        public static Color PRIMARY { get; } = (Color)MyColors["Primary"];
        public static Color SECONDARY { get; } = (Color)MyColors["Secondary"];
        public static Color TERTIARY { get; } = (Color)MyColors["Tertiary"];

        public static double WIDTH = DeviceDisplay.MainDisplayInfo.Width/ DeviceDisplay.MainDisplayInfo.Density;
        public static double HEIGHT = DeviceDisplay.MainDisplayInfo.Height/ DeviceDisplay.MainDisplayInfo.Density;
        public static double DENSITY = DeviceDisplay.MainDisplayInfo.Density;
        public static double DENSITY_FACTOR { get; } = 2.75 / DeviceDisplay.MainDisplayInfo.Density;
        public static double ENTRY_FONT_SIZE { get;  } = DPI.DENSITY_FACTOR * 19;
        public static double BUTTON_FONT_SIZE { get;  } = DPI.DENSITY_FACTOR * 18;
    }
}
