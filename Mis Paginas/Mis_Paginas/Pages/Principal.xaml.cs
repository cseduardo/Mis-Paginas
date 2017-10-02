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
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void misdatos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.Primera());
        }

        private void ingresarDatos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.DatosPersonales());
        }

        private void calculadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.Calculadora());
        }
    }
}