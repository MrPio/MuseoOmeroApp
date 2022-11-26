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
    public class NegozioViewModel : BindableObject
    {
        public TopBarViewModel TopBar { get; set; } = new("Negozio");

        public BigRoundedIconViewModel BigRoundedIcon { get; set; } = new(IconFont.Cart);

        private ObservableCollection<NegozioItemViewModel> _negozioItems = new()
        {
            new(DPI.PRIMARY,"Museo Aperto","Ingresso gratuito.",IconFont.Ticket,0,false),
            new(DPI.TERTIARY,"Mostra","Ingresso a pagamento.",IconFont.Paw,2,false),
            new(DPI.TERTIARY,"Laboratorio","Ingresso a pagamento.",IconFont.Puzzle,3,false),
        };
        public ObservableCollection<NegozioItemViewModel> NegozioItems
        {
            get { return _negozioItems; }
            set { _negozioItems = value; OnPropertyChanged(); }
        }


        public double FontSize { get; set; } = DPI.ENTRY_FONT_SIZE;
        public double IconSize { get; set; } = DPI.DENSITY_FACTOR * 32;

    }
}
