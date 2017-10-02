using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_Paginas.Pages;
using Mis_Paginas.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mis_Paginas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDatos : ContentPage
    {
        public MDatos()
        {
            InitializeComponent();
            dCompletos.Text = "NOMBRE COMPLETO: " + locals.nombre + " " + locals.ape_pat + " " + locals.ape_mat + " TELEFONO: " +
                locals.num_telefono + "\nDOMICILIO\nCALLE: " + locals.calle + " NUMERO: " + locals.num_calle + " CODIGO POSTAL: " +
                locals.cod_postal + "\nMUNICIPIO: " + locals.municipio + "\nESTADO: " + locals.estado + "\n ESCUELA\nCARRERA: " +
                locals.carrera + " SEMESTRE: " + locals.semestre + " MATRICULA: " + locals.id + "\nSOCIALES\nCORREO: " + locals.email +
                "\ngitHub: " + locals.git;
        }
        private void pricipalPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.DatosPersonales());
        }
        private void finish_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.Principal());
        }
    }
}