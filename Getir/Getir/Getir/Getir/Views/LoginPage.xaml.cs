﻿

using Getir.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            List<string> CarouselItems = new List<string>()
            {
                "https://cdn.getir.com/misc/5f914227478dc67ed04805c9_banner_tr_1610902370241.jpeg",
                "https://cdn.getir.com/misc/6013ee562c249596f9b93ca9_banner_tr_1611919010105.jpeg",
                "https://cdn.getir.com/misc/5ff82628eaffa13a73c6b0b7_banner_tr_1610905815267.jpeg"
            };
            girisCarousel.ItemsSource = CarouselItems;

        }
        private async void girisYapPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GirisPage());
        }
    }

}