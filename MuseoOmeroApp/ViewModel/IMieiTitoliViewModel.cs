using CommunityToolkit.Mvvm.ComponentModel;
using MuseoOmeroApp.Helpers;
using MuseoOmeroApp.ViewModel.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel
{
    public partial class IMieiTitoliViewModel:ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<BigliettoViewModel> biglietti = new()
        {
            new(),
            new(DateTime.Today,"Mostra","Turno guida alle 12:45",IconFont.Paw),
            new(),
            new(),
            new(),
            new(),
        };
    }
}
