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
        const int UNSELECTED_FONT_SIZE = 25;
        const int SELECTED_FONT_SIZE = 32;

        [ObservableProperty]
        int _fontSize1 = UNSELECTED_FONT_SIZE;
        [ObservableProperty]
        int _fontSize2 = UNSELECTED_FONT_SIZE;
        [ObservableProperty]
        int _fontSize3 = UNSELECTED_FONT_SIZE;
        [ObservableProperty]
        int _fontSize4 = UNSELECTED_FONT_SIZE;

        int _selectedViewModelIndex;

        public int SelectedViewModelIndex
        {
            get => _selectedViewModelIndex;
            set
            {
                _selectedViewModelIndex = value;
                OnPropertyChanged(nameof(SelectedViewModelIndex));
                FontSize1 = UNSELECTED_FONT_SIZE; FontSize2 = UNSELECTED_FONT_SIZE; 
                FontSize3 = UNSELECTED_FONT_SIZE; FontSize4 = UNSELECTED_FONT_SIZE;
                switch (value)
                {
                    case 0: FontSize1 = SELECTED_FONT_SIZE; topBarViewModel.Title = "I miei titoli"; break;
                    case 1: FontSize2 = SELECTED_FONT_SIZE; topBarViewModel.Title = "Account"; break;
                    case 2: FontSize3 = SELECTED_FONT_SIZE; topBarViewModel.Title = "Biglietteria"; break;
                    case 3: FontSize4 = SELECTED_FONT_SIZE; topBarViewModel.Title = "Prenotazioni"; break;
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

                TopAndBottomWavesViewModel.TopWaveTranslationY = -easingValue * 60;
                TopAndBottomWavesViewModel.BottomWaveTranslationY = easingValue * 30;
                TopBarViewModel.TranslationY = -easingValue * 30;
                BottomBarTranslationX =  easingValue * 30;
                BottomBarOpacity = 1 - easingValue;
                TopBarViewModel.Opacity = 1 - easingValue * 1.5;
                TopBarViewModel.RicercaOpacity = 1 - easingValue * 1.5;
            }
        }

        [ObservableProperty]
        bool loading = false;
    }
}
    