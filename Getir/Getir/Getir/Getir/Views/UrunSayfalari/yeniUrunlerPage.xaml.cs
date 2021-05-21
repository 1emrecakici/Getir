using Getir.Views.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir.Views.UrunSayfalari
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class yeniUrunlerPage : ContentPage
    {
        public yeniUrunlerPage()
        {
            InitializeComponent();
        }
        
        private async void yeniUrunler_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yeniUrunlerPage());
        }
        private async void polonezPastirmaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new polonezPastirmaPage());
        }
        private async void hertaneZeytinPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hertaneZeytinPage());
        }

        private async void herbyFitElmaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new herbyFitElmaPage());
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