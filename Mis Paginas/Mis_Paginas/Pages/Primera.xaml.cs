using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mis_Paginas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Primera : ContentPage
    {
        public Primera()
        {
            InitializeComponent();
        }

        private void principal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.Principal());
        }
    }
}