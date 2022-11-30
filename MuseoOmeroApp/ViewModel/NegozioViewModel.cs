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
    public partial class NegozioViewModel : ObservableObject
    {
        public TopBarViewModel TopBar { get; set; } = new("Negozio");

        public BigRoundedIconViewModel BigRoundedIcon { get; set; } = new(IconFont.Cart);

        //private ObservableCollection<NegozioItemViewModel> _negozioItems = new()
        //{
        //    new(DPI.PRIMARY,"Museo Aperto","Ingresso gratuito.",IconFont.Ticket,0,false),
        //    new(DPI.TERTIARY,"Mostra","Ingresso a pagamento.",IconFont.Paw,2,false),
        //    new(DPI.TERTIARY,"Laboratorio","Ingresso a pagamento.",IconFont.Puzzle,3,false),
        //};
        //public ObservableCollection<NegozioItemViewModel> NegozioItems
        //{
        //    get { return _negozioItems; }
        //    set { _negozioItems = value; OnPropertyChanged(); }
        //}

        [ObservableProperty]
        NegozioItemViewModel _bigliettoMuseo = new(DPI.PRIMARY, "Museo Aperto", "Ingresso gratuito.", IconFont.Ticket, 0, false);
      
        [ObservableProperty]
        NegozioItemViewModel _bigliettoMostra = new(DPI.TERTIARY, "Mostra", "Ingresso a pagamento.", IconFont.Paw, 2, false);
      
        [ObservableProperty]
        NegozioItemViewModel _bigliettoLaboratorio = new(DPI.TERTIARY, "Laboratorio", "Ingresso a pagamento.", IconFont.Puzzle, 3, false);

        public double FontSize { get; set; } = DPI.ENTRY_FONT_SIZE;
        public double IconSize { get; set; } = DPI.DENSITY_FACTOR * 32;

    }
}
