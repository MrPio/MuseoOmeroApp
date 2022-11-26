using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public class BigRoundedIconViewModel : BindableObject
    {
        public BigRoundedIconViewModel(string icon)
        {
            Icon = icon;
        }

        public double BigIconSize { get; set; } = DPI.DENSITY_FACTOR * 110;
        public double BigIconIconSize { get; set; } = DPI.DENSITY_FACTOR * 60;

        public string Icon { get; set; }
        private double _opacity = 0;
        public double Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                OnPropertyChanged(nameof(Opacity));
            }
        }
    }
}
