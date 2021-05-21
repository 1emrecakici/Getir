using Getir.Views.UrunSayfalari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
                "https://cdn.getir.com/misc/5f914227478dc67ed04805c9_banner_tr_1610902370241.jpeg",
                "https://cdn.getir.com/misc/6013ee562c249596f9b93ca9_banner_tr_1611919010105.jpeg",
                "https://cdn.getir.com/misc/5ff82628eaffa13a73c6b0b7_banner_tr_1610905815267.jpeg"
            };
            ilkCarousel.ItemsSource = CarouselItems;

        }

        private async void yeniUrunler_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yeniUrunlerPage());
        }
        private async void indirimler_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new indirimlerPage());
        }
        private async void meyveSebze_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new meyveSebzePage());
        }
        private async void icecek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new icecekPage());
        }
        private async void firindan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new firindanPage());
        }
        private async void temelGida_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new temelGidaPage());
        }
        private async void atistirmalik_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new atistirmalikPage());
        }
        private async void dondurma_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dondurmaPage());
        }
        private async void yiyecek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yiyecekPage());
        }
        private async void kahvalti_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kahvaltiPage());
        }
        private async void form_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new formPage());
        }
        private async void kisiselBakim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kisiselBakimPage());
        }
        private async void evBakim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new evBakimPage());
        }
        private async void yasam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yasamPage());
        }
        private async void teknoloji_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new teknolojiPage());
        }
        private async void hayvan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hayvanPage());
        }
        private async void bebek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new bebekPage());
        }
        private async void cinselSaglik_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cinselSaglikPage());
        }
        private async void giyim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new giyimPage());
        }
    }
}