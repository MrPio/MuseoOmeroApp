using CommunityToolkit.Mvvm.ComponentModel;
using MuseoOmeroApp.ViewModel.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel
{
    public partial class MainPageViewModel:ObservableObject
    {
        [ObservableProperty]
        int _fontSize1 = 27;
        [ObservableProperty]
        int _fontSize2 = 27;
        [ObservableProperty]
        int _fontSize3 = 27;
        [ObservableProperty]
        int _fontSize4 = 27;

        int _selectedViewModelIndex;

        public int SelectedViewModelIndex
        {
            get => _selectedViewModelIndex;
            set
            {
                _selectedViewModelIndex = value;
                OnPropertyChanged(nameof(SelectedViewModelIndex));
                FontSize1 = 27; FontSize2 = 27; FontSize3 = 27; FontSize4 = 27;
                switch (value)
                {
                    case 0: FontSize1 = 34; topBarViewModel.Title = "Account"; break;
                    case 1: FontSize2 = 34; topBarViewModel.Title = "I miei titoli"; break;
                    case 2: FontSize3 = 34; topBarViewModel.Title = "Biglietteria"; break;
                    case 3: FontSize4 = 34; topBarViewModel.Title = "Prenotazioni"; break;
                }
            }
        }

        [ObservableProperty]
        HomeViewModel _homeViewModel = new();


        [ObservableProperty]
        IMieiTitoliViewModel _iMieiTitoliViewModel = new();

        [ObservableProperty]
        double _wavesTranslation=0;

        [ObservableProperty]
        double _waves2Translation=DPI.WIDTH;

        [ObservableProperty]
        TopBarViewModel topBarViewModel=new();

        [ObservableProperty]
        TopAndBottomWavesViewModel topAndBottomWavesViewModel=new();

        [ObservableProperty]
        double bottomBarTranslationX,bottomBarOpacity=1;

        double wavesExpandFactor = 0;
        public double WavesExpandFactor
        {
            get => wavesExpandFactor;
            set {
                wavesExpandFactor = value;
                var easingValue = Easing.CubicIn.Ease(value);
                var easingValueHalf = Easing.CubicIn.Ease(Math.Max(0,value-0.2));

                TopAndBottomWavesViewModel.TopWaveTranslationY = -easingValue * 60;
                TopAndBottomWavesViewModel.BottomWaveTranslationY = easingValue * 30;
                TopBarViewModel.TranslationY = -easingValue * 30;
                BottomBarTranslationX =  easingValue * 30;
                BottomBarOpacity = 1 - easingValue;
                TopBarViewModel.Opacity = 1 - easingValue * 1.5;
                TopBarViewModel.RicercaOpacity = 1 - easingValue * 1.5;
            }
        }
    }
}
    