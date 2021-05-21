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
    public partial class Header : TabbedPage
    {
        public Header(Page1 page1)
        {
            InitializeComponent();
        }
    }
}