
using MuseoOmeroApp.Helpers;
using MuseoOmeroApp.Models;
using MuseoOmeroApp.ViewModel.Templates;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MuseoOmeroApp.ViewModel
{
    public class HomeModelView : BindableObject
    {
        ObservableCollection<ModelEntry> _anagraficaEntries = new()
        {
            new ModelEntry("Nome","Mario",IconFont.Pen),
            new ModelEntry("Cognome","Rossi",IconFont.Pencil),
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

        public ObservableCollection<ModelEntry> AnagraficaEntries
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

        public TopBarViewModel TopBar { get; set; } = new("Anagrafica");

    }
}
