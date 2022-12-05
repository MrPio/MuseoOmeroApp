using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MuseoOmeroApp.Helpers;
using MuseoOmeroApp.View.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public partial class BigliettoViewModel:ObservableObject
    {
        public Biglietto View;

        public BigliettoViewModel(DateTime data=default, 
            string tipologiaBiglietto="Museo aperto", string turnoGuida="No turno guida.",
            string icon=IconFont.TicketConfirmation)
        {
            Data = data;
            TipologiaBiglietto = tipologiaBiglietto;
            TurnoGuida = turnoGuida;
            Icon = icon;
        }

        [ObservableProperty]
        DateTime data;

        [ObservableProperty]
        string tipologiaBiglietto,turnoGuida,icon;

        [RelayCommand]
        void VaiAlBigliettoClicked()
        {
            View.Button_Clicked();
        }

    }
}
