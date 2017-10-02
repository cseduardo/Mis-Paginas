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
    public partial class Calculadora : ContentPage
    {
        decimal primerNumero = 0;
        decimal segundoNumero = 0;
        string operacion;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void input(string a)
        {
            if (mostrar.Text == "0")
                mostrar.Text = a;
            else
                mostrar.Text += a;
        }

        private void porciento_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "%";
            //mostrar2.Text = mostrar2.Text + "%";
        }

        private void raiz_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = (Math.Sqrt(double.Parse(mostrar.Text))).ToString();
            //mostrar2.Text = mostrar2.Text + "√";
        }

        private void cuadrado_Clicked(object sender, EventArgs e)
        {
            primerNumero = decimal.Parse(mostrar.Text);
            operacion = "^";
            mostrar.Text = "";
            //mostrar2.Text = mostrar2.Text + "^2";
        }

        private void borrar_todo_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = null;
            //mostrar2.Text = null;
        }

        private void borrar_ultimo_Clicked(object sender, EventArgs e)
        {

            if (mostrar.Text == "" && mostrar.Text.Length > 0)
            {
                mostrar.Text = "";
                //mostrar2.Text = "";
            }
        }

        private void borrar_Clicked(object sender, EventArgs e)
        {
            if (mostrar.Text.Length > 0 /*&& mostrar2.Text.Length > 0*/)
            {
                mostrar.Text = mostrar.Text.Substring(0, mostrar.Text.Length - 1);
                //mostrar2.Text = mostrar2.Text.Substring(0, mostrar2.Text.Length - 1);
            }
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            primerNumero = decimal.Parse(mostrar.Text);
            operacion = "/";
            mostrar.Text = "";
        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            input("7");
            //mostrar2.Text = mostrar2.Text + "7";
        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            input("8");
            //mostrar2.Text = mostrar2.Text + "8";
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            input("9");
            //mostrar2.Text = mostrar2.Text + "9";
        }

        private void mult_Clicked(object sender, EventArgs e)
        {
            primerNumero = decimal.Parse(mostrar.Text);
            operacion = "*";
            mostrar.Text = "0";
        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            input("4");

            //mostrar2.Text = mostrar2.Text + "4";
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            input("5");
            //mostrar2.Text = mostrar2.Text + "5";
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            input("6");
            //mostrar2.Text = mostrar2.Text + "6";
        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            primerNumero = decimal.Parse(mostrar.Text);
            operacion = "-";
            mostrar.Text = "";
        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            input("1");
            //mostrar2.Text = mostrar2.Text + "1";
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            input("2");
            //mostrar2.Text = mostrar2.Text + "2";
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            input("3");
            //mostrar2.Text = mostrar2.Text + "3";
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            primerNumero = decimal.Parse(mostrar.Text);
            operacion = "+";
            mostrar.Text = "";
        }

        private void absoluto_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text + "";
        }

        private void cero_Clicked(object sender, EventArgs e)
        {
            input("0");
            //mostrar2.Text = mostrar2.Text + "0";
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            if (!mostrar.Text.Contains("."))
            {
                mostrar.Text = mostrar.Text + ".";
                //mostrar2.Text = mostrar2.Text + ".";
            }
        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            segundoNumero = decimal.Parse(mostrar.Text);
            ////////////////////////////////
            switch (operacion)
            {
                case "+":
                    mostrar.Text = (primerNumero + segundoNumero).ToString();
                    break;
                case "-":
                    mostrar.Text = (primerNumero - segundoNumero).ToString();
                    break;
                case "*":
                    mostrar.Text = (primerNumero * segundoNumero).ToString();
                    break;
                case "/":
                    if (primerNumero == 0 && segundoNumero == 0)
                    {
                        mostrar.Text = "No se puede dividir entre cero";
                    }
                    else
                    {
                        if (segundoNumero == 0)
                        {
                            mostrar.Text = "0";
                        }
                        else
                        {
                            mostrar.Text = (primerNumero / segundoNumero).ToString();
                        }
                    }
                    break;
                case "^":
                    mostrar.Text = (int.Parse(primerNumero.ToString()) ^ int.Parse(segundoNumero.ToString())).ToString();
                    break;
                case "%":
                    mostrar.Text = (primerNumero % segundoNumero).ToString();
                    break;
            }
        }

        private void sen_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = (Math.Sin(double.Parse(mostrar.Text))).ToString();
        }

        private void cos_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = (Math.Cos(double.Parse(mostrar.Text))).ToString();
        }

        private void tan_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = (Math.Tan(double.Parse(mostrar.Text))).ToString();
        }

        private void log_Clicked(object sender, EventArgs e)
        {
            mostrar.Text = (Math.Log(double.Parse(mostrar.Text))).ToString();
        }

        private void factorial_Clicked(object sender, EventArgs e)
        {
            long f = 1;
            for (long i = 1; i <= long.Parse(mostrar.Text); i++)
            {
                f = f * i;
            }
            mostrar.Text = f.ToString();
        }

        private void modulo_Clicked(object sender, EventArgs e)
        {
            primerNumero = decimal.Parse(mostrar.Text);
            operacion = "%";
            mostrar.Text = "";
        }

        private void pag_Prin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.Principal());
        }
    }
}