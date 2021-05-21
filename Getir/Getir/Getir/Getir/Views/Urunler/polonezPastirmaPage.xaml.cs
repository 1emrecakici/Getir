using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir.Views.Urunler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class polonezPastirmaPage : ContentPage
    {
        int adet = 1;
        public polonezPastirmaPage()
        {
            InitializeComponent();

        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                adet = Convert.ToInt32((picker.ItemsSource[selectedIndex] as string)[0].ToString());
            }
        }

        private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label1.Text = e.NewValue.ToString();;
        }


    }
}