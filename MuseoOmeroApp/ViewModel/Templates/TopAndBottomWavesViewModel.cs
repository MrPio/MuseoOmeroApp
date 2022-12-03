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
        GridLength _topWave=58, _bottomWave=44, _intersection=10;
    }
}
