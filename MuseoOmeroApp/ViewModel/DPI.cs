using MuseoOmeroApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel
{
    class DPI
    {
        public static Page mainPage;
        private static ResourceDictionary MyColors = 
            Application.Current.Resources.MergedDictionaries.First();
        public static Color PRIMARY { get; } = (Color)MyColors["Primary"];
        public static Color SECONDARY { get; } = (Color)MyColors["Secondary"];
        public static Color TERTIARY { get; } = (Color)MyColors["Tertiary"];

        public static Color COL_1 { get; } = (Color)MyColors["Color1"];
        public static Color COL_2 { get; } = (Color)MyColors["Color2"];
        public static Color COL_3 { get; } = (Color)MyColors["Color3"];
        public static Color COL_4 { get; } = (Color)MyColors["Color4"];
        public static Color COL_5 { get; } = (Color)MyColors["Color5"];

        public static double WIDTH
        {
            get
            {
                if (mainPage==null)
                    return DeviceDisplay.MainDisplayInfo.Width / DENSITY;
                else
                    return mainPage.Width;
            }
        }
        public static double HEIGHT
        {
            get
            {
                if (mainPage == null)
                    return DeviceDisplay.MainDisplayInfo.Height / DENSITY;
                else
                    return mainPage.Height;
            }
        }
        public static double DENSITY
        {
            get
            {
                return DeviceDisplay.MainDisplayInfo.Density ==0?1: DeviceDisplay.MainDisplayInfo.Density;
            }
        }

        public static double DENSITY_FACTOR
        {
            get
            {
#if ANDROID
                return 2.75 / DENSITY;
#elif WINDOWS
                return 1 / DENSITY;
#else
                return 1;
#endif
            }
        }


        public static double ENTRY_FONT_SIZE { get;  } = DPI.DENSITY_FACTOR * 19;
        public static double BUTTON_FONT_SIZE { get;  } = DPI.DENSITY_FACTOR * 18;
    }
}
