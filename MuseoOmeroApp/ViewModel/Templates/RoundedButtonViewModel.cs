namespace MuseoOmeroApp.ViewModel.Templates
{
    public class RoundedButtonViewModel : BindableObject
    {
        private string _text;
        private Func<bool> _onClick;

        public RoundedButtonViewModel(string text, Func<bool> onClick)
        {
            _text = text;
            _onClick = onClick;
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged(); }
        }

        public Func<bool> OnClick
        {
            get { return _onClick; }
            set { _onClick = value; OnPropertyChanged(); }
        }
    }
}
