
using CommunityToolkit.Mvvm.ComponentModel;
using MuseoOmeroApp.Helpers;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public partial class TopBarViewModel: ObservableObject
    {

        [ObservableProperty]
        RoundedEntryViewModel _roundedEntryViewModel =
            new("Ricerca", "", IconFont.Magnify,0.9,DPI.COL_2,1,2.6,default,true);

        [ObservableProperty]
        string title = "Anagrafica";

        [ObservableProperty]
        double ricercaOpacity=1,translationY=0,opacity=1;
    }
}
