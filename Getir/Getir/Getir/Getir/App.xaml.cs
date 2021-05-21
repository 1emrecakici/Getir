using Getir.Services;
using Getir.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DLToolkit.Forms.Controls;
using System.IO;

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