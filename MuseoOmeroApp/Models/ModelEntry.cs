using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MuseoOmeroApp.Models
{
    public class ModelEntry : ObservableObject
    {
        public ModelEntry(string placeholder, string text, string icon)
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
    }
}
