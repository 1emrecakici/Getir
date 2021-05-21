using Getir.Tables;
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

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            /*collectionView.ItemsSource = await App.Database.GetPeopleAsync();*/
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KaydolPage());
        }
        async void Btn_Clicked(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatebase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if(myquery != null)
            {
                await Shell.Current.GoToAsync("//AboutPage");
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed User Name and Password", "Yes", "Cancel");
                    if (result)
                        await Navigation.PushAsync(new GirisPage());
                    else
                    {
                        await Navigation.PushAsync(new AboutPage());
                    }
                });
            }
        }

        
    }
}