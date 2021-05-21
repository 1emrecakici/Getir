using Getir.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Getir.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}