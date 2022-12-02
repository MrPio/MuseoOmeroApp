
using MuseoOmeroApp.Helpers;
using MuseoOmeroApp.Models;
using MuseoOmeroApp.ViewModel.Templates;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MuseoOmeroApp.ViewModel
{
    public class HomeViewModel : BindableObject
    {
        ObservableCollection<RoundedEntryViewModel> _anagraficaEntries = new()
        {
            new RoundedEntryViewModel("Nome","Mario",IconFont.Pen),
            new RoundedEntryViewModel("Cognome","Rossi",IconFont.Pencil),
        };

        private string _sessoIcon = IconFont.GenderMale;
        public string SessoIcon
        {
            get { return _sessoIcon; }
            set { _sessoIcon = value; OnPropertyChanged(nameof(SessoIcon)); }
        }

        private string _sessoItem = "Maschio";
        public string SessoItem
        {
            get { return _sessoItem; }
            set { 
                _sessoItem = value;
                SessoIcon = value switch
                {
                    "Maschio" => IconFont.GenderMale,
                    "Femmina" => IconFont.GenderFemale,
                    _ => IconFont.GenderMaleFemale,
                };
                OnPropertyChanged(nameof(SessoItem));
            }
        }

        public ObservableCollection<RoundedEntryViewModel> AnagraficaEntries
        {
            get { return _anagraficaEntries; }
            set { _anagraficaEntries = value; OnPropertyChanged(); }
        }

        public ObservableCollection<string> Sesso { get; set; } = new()
        {
            "Maschio","Femmina","NonSpecificato"
        };

        public ObservableCollection<FABViewModel> ModelFAB { get; set; } = new()
        {
            new(IconFont.ContentSave, new Command<FABViewModel>((obj) =>
             {
                 //save
                return;
            })),
        };

        public TopBarViewModel TopBar { get; set; } = new();

        public BigRoundedIconViewModel BigRoundedIcon { get; set; } = new(IconFont.BagPersonal);


        public double FontSize { get; set; } = DPI.ENTRY_FONT_SIZE;
        public double IconSize { get; set; } = DPI.DENSITY_FACTOR * 32;



    }
}
