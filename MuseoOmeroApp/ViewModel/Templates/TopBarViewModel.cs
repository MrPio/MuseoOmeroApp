
using CommunityToolkit.Mvvm.ComponentModel;
using MuseoOmeroApp.Helpers;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public partial class TopBarViewModel: ObservableObject
    {

        [ObservableProperty]
        RoundedEntryViewModel _roundedEntryViewModel =
            new("Ricerca", "", IconFont.TextBoxSearch,0.9,DPI.COL_2,1,2.6);

        [ObservableProperty]
        string _title = "Anagrafica";

        [ObservableProperty]
        double _ricercaOpacity=0;
    }
}
