using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
{
                "https://cdn.getir.com/misc/5f914227478dc67ed04805c9_banner_tr_1610902370241.jpeg",
                "https://cdn.getir.com/misc/6013ee562c249596f9b93ca9_banner_tr_1611919010105.jpeg",
                "http://cdn.getir.com/misc/606765d0f7ac3c3bc2c84764_banner_tr_1617389030292.jpeg",
                "http://cdn.getir.com/misc/6066e191beddbc0fb855b9f1_banner_tr_1617355642020.jpeg"
            };
            ilkCarousel.ItemsSource = CarouselItems;
        }
    }
}