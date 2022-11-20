using MuseoOmeroApp.Helpers;
using MuseoOmeroApp.Models;
using System.Collections.ObjectModel;
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

        public ObservableCollection<ModelEntry> ModelEntries
        {
            get { return _modelEntries; }
            set { _modelEntries = value; OnPropertyChanged(); }
        }

        public static void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            int i = 0;
        }

    }
}
