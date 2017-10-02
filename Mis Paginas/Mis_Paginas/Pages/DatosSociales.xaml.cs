using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_Paginas.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mis_Paginas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatosSociales : ContentPage
    {
        public DatosSociales()
        {
            InitializeComponent();
        }
        public void nextPagen(object sender, EventArgs e)
        {
            locals.email = correo.Text;
            locals.git = github.Text;
            Navigation.PushModalAsync(new MDatos());
        }
    }
}