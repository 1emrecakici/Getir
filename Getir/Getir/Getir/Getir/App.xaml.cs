using Getir.Services;
using Getir.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DLToolkit.Forms.Controls;
using System.IO;
using Xamarin.Essentials;

namespace Getir
{
    public partial class App : Application
    {
        
        public App()
        {
           
            InitializeComponent();

             DependencyService.Register<MockDataStore>();
             MainPage = new AppShell();
             FlowListView.Init();

           /* string uname = Preferences.Get("Username", String.Empty);
            if(String.IsNullOrEmpty(uname))
            {
                MainPage = new AboutPage();
            }
            else
            {
                MainPage = new ProductView();
            }
            */
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}