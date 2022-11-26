using CommunityToolkit.Mvvm.ComponentModel;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public class RoundedEntryViewModel : ObservableObject
    {
        public RoundedEntryViewModel(string placeholder, string text, string icon)
        {
            Placeholder = placeholder;
            Text = text;
            Icon = icon;
        }

        public string Placeholder { get; set; }

        private string _text;
        public string Text { 
            get => _text;
            set
            {
                SetProperty(ref _text, value);
            } 
        }
        public string Icon { get; set; }

        public double FontSize { get; set; } = DPI.ENTRY_FONT_SIZE;
        public double IconSize { get; set; } = DPI.DENSITY_FACTOR * 32;

    }
}
