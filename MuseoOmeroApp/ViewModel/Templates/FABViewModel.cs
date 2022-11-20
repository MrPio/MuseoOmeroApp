﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel.Templates
{
    public class FABViewModel
    {
        public string TextIcon { get; set; }
        public Command<FABViewModel> OnClick { get; set; }

        public FABViewModel(string textIcon, Command<FABViewModel> onClick)
        {
            TextIcon = textIcon;
            OnClick= onClick;
        }
    }
}
