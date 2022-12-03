using CommunityToolkit.Mvvm.ComponentModel;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public partial class RoundedEntryViewModel : ObservableObject
    {
        public RoundedEntryViewModel(string placeholder, string text, string icon,
            double fontScale=1, Color entryBorderColor=null, double borderTicknessFocused = 2.6,
            double borderTicknessUnfocused=1)
        {
            Placeholder = placeholder;
            Text = text;
            Icon = icon;
            FontSize = DPI.ENTRY_FONT_SIZE * fontScale;
            EntryBorderColor = entryBorderColor??Color.FromHex("#c8c8c8");
            BorderTicknessFocused = borderTicknessFocused;
            BorderTicknessUnfocused= borderTicknessUnfocused;
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

        [ObservableProperty]
        Color _entryBorderColor;

        [ObservableProperty]
        double _borderTicknessFocused;

        [ObservableProperty]
        double _borderTicknessUnfocused;


    }
}
