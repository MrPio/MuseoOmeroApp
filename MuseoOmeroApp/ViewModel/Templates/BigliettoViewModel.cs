using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MuseoOmeroApp.Models;
using MuseoOmeroApp.View.Templates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public partial class BigliettoViewModel:ObservableObject
    {
        public BigliettoView View;

        [ObservableProperty]
        DateTime data;

        [ObservableProperty]
        string tipologiaBiglietto, turnoGuida, icon;

        public BigliettoViewModel(Biglietto biglietto)
        {
            Data = biglietto.DataValidita;
            TipologiaBiglietto = biglietto.Tipologia.Value;
            TurnoGuida = biglietto.DataGuida==null?"No turno guida.":"Guida alle "+
               biglietto.DataGuida?.ToString("HH:mm");
            Icon = biglietto.Tipologia.Icon;
        }



        [RelayCommand]
        void VaiAlBigliettoClicked()
        {
            View.Button_Clicked();
        }

    }
}
