using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MuseoOmeroApp.Helpers;
using MuseoOmeroApp.Pages;
using MuseoOmeroApp.View;
using MuseoOmeroApp.ViewModel.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoOmeroApp.ViewModel
{
    public partial class IMieiTitoliViewModel:ObservableObject
    {
        public IMieiTitoli view;
        [ObservableProperty]
        ObservableCollection<BigliettoViewModel> biglietti;

        [RelayCommand]
        async void AggiornaClicked()
        {
            var mainPage = (MainPage)view.Parent.Parent.Parent.Parent.Parent;
            var mainPageViewModel = (MainPageViewModel)mainPage.BindingContext;
            mainPageViewModel.Loading = true;
            Biglietti =new ObservableCollection<BigliettoViewModel>(await mainPage.Service.LoadBiglietti());
            mainPageViewModel.Loading = false;
        }
    }
}
