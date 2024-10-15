using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticografo_XGVC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string _Nombre = Nombre.Text;
            //if (string.IsNullOrWhiteSpace(_Nombre))
            //{
              ///  DisplayAlert("Error", "Por favor ingresa un nombre.", "Cerrar");
                //return;
            //}
            string nom = _Nombre + " Es";

            if (Muj.IsChecked)
            {
                nom = nom + "Mujer, ";
            }
            else if (hom.IsChecked)
            {
                nom = nom + "Hombre, ";
            }

            if (Alto.IsChecked)
            {
                nom = nom + "Alto, ";
            }
            if (Grande.IsChecked)
            {
                nom = nom + "Grande, ";
            }
            if (Lista.IsChecked)
            {
                nom = nom + "Lista, ";
            }
            if (Feo.IsChecked)
            {
                nom = nom + "Feo, ";
            }
            if (Extravagante.IsChecked)
            {
                nom = nom + "Extravagante, ";
            }
            if (Raro.IsChecked)
            {
                nom = nom + "Raro, ";
            }
            DisplayAlert("Resultado", nom, "Cerrar");


        }
    }
}
