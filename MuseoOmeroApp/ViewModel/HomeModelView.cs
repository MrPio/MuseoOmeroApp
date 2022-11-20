
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
        ObservableCollection<ModelEntry> _modelEntries = new()
        {
            new ModelEntry("prova1","testo2",IconFont.Abacus),
            new ModelEntry("prova2","testo3",IconFont.AbjadHebrew)
        };

        ObservableCollection<RoundedButtonViewModel> _modelButton = new()
        {
            new("LOG",() => {
                return true;
            }),
        };




        public ObservableCollection<ModelEntry> ModelEntries
        {
            get { return _modelEntries; }
            set { _modelEntries = value; OnPropertyChanged(); }
        }
        public ObservableCollection<RoundedButtonViewModel> ModelButton
        {
            get { return _modelButton; }
            set { _modelButton = value; OnPropertyChanged(); }
        }

        public static void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            int i = 0;
        }

        public ObservableCollection<FABViewModel> ModelFAB { get; set; } = new()
        {
            new(IconFont.Star, new Command<FABViewModel>((obj) =>
             {
                 int i=0;
                return;
            })),
        };

    }
}
