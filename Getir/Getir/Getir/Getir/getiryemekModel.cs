using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Getir
{
    class getiryemekModel : BindableObject
    {
        private Page Page;



        public getiryemekModel(Page mainPage)
        {
            this.Page = mainPage;
            AddItems();
        }



        private void AddItems()
        {
            for (int i = 0; i < 20; i++)
            {
                getiryemekItem GetiryemekItem = new getiryemekItem()
                {
                    ImageSource = "https://cdn.getiryemek.com/cuisines/1609163756273_480x300.jpeg",
                    ÜrünKategorisi = string.Format("ÜrünKategorisi {0}", i)
                };
                Items.Add(GetiryemekItem);
            }

        }



        private ObservableCollection<getiryemekItem> _items = new ObservableCollection<getiryemekItem>();
        public ObservableCollection<getiryemekItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }



        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}
