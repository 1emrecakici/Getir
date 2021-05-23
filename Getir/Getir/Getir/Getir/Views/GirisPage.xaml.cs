
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisPage : ContentPage
    {
        public GirisPage()
        {
            InitializeComponent();
        }

        

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KaydolPage());
        }
    }
}