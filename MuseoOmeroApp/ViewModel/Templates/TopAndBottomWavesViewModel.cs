using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public partial class TopAndBottomWavesViewModel:ObservableObject
    {
        [ObservableProperty]
        GridLength topWave=114, bottomWave=44, intersection=10;

        [ObservableProperty]
        double topWaveTranslationY = 0, bottomWaveTranslationY = 0;
    }
}
