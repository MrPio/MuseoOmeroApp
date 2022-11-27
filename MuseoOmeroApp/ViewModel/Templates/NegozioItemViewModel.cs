using MuseoOmeroApp.Helpers;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public class NegozioItemViewModel: BindableObject
    {
        private Color _backgroundColor { get; set; }
        private string _title { get; set; }
        private string _subtitle { get; set; }
        private string _iconText { get; set; }
        private int _price { get; set; }
        private bool _preferred { get; set; }
        private string _starIconText = IconFont.Star;
        private bool _moneyIcon0Visible = true;
        private bool _moneyIcon1Visible = false;
        private bool _moneyIcon2Visible = false;
        private bool _moneyIcon3Visible = false;

        public NegozioItemViewModel(Color backgroundColor, string title, string subtitle, string iconText, int price, bool preferred)
        {
            BackgroundColor = backgroundColor;
            Title = title;
            Subtitle = subtitle;
            IconText = iconText;
            Price = price;
            Preferred = preferred;
        }

        public Color BackgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; OnPropertyChanged(); } }
        public Color BackgroundIconColor { get { return _backgroundColor == DPI.PRIMARY ? DPI.TERTIARY : DPI.PRIMARY; } }
        public Color TextColor { get { return _backgroundColor == DPI.PRIMARY ? Colors.White : DPI.PRIMARY; } }
        public string Title { get { return _title; } set { _title = value; OnPropertyChanged(); } } 
        public string Subtitle { get { return _subtitle;} set { _subtitle = value; OnPropertyChanged(); } }
        public string IconText { get { return _iconText; } set { _iconText = value; OnPropertyChanged(); } }
        public double IconSize { get;  } = DPI.DENSITY_FACTOR * 60;
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value; OnPropertyChanged(nameof(Price));
                MoneyIcon1Visible = false;
                MoneyIcon2Visible = false;
                MoneyIcon3Visible = false;
                if (value == 0)
                    MoneyIcon0Visible = true;
                else
                    MoneyIcon0Visible = false;

                if (value > 0)
                    MoneyIcon1Visible = true;
                if (value > 1)
                    MoneyIcon2Visible = true;
                if (value > 2)
                    MoneyIcon3Visible = true;
            }
        }
        public bool Preferred { get { return _preferred; } set { _preferred = value; OnPropertyChanged(nameof(Preferred)); StarIconText = Preferred ? IconFont.Star : IconFont.StarOutline; } }
        public bool MoneyIcon0Visible { get { return _moneyIcon0Visible; } set { _moneyIcon0Visible = value; OnPropertyChanged(nameof(MoneyIcon0Visible)); } } 
        public bool MoneyIcon1Visible { get { return _moneyIcon1Visible; } set { _moneyIcon1Visible = value; OnPropertyChanged(nameof(MoneyIcon1Visible)); } }
        public bool MoneyIcon2Visible { get { return _moneyIcon2Visible; } set { _moneyIcon2Visible = value; OnPropertyChanged(nameof(MoneyIcon2Visible)); } }
        public bool MoneyIcon3Visible { get { return _moneyIcon3Visible; } set { _moneyIcon3Visible = value; OnPropertyChanged(nameof(MoneyIcon3Visible)); } }

        private RowDefinitionCollection _gridRows= new RowDefinitionCollection() {new RowDefinition(120),};
        public RowDefinitionCollection GridRows { get { return _gridRows; } set { _gridRows = value; OnPropertyChanged(nameof(GridRows)); } }
        
        public string StarIconText { get { return _starIconText; } set { _starIconText = value; OnPropertyChanged(nameof(StarIconText)); } }
        //{ get {return Preferred ? IconFont.Star : IconFont.StarOutline;} }

        private double _height = 120;
        public double Height { get { return _height;} set { _height = value; OnPropertyChanged(); } }
    }
}
