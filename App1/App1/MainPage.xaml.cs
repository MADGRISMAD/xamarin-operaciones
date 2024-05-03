using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EventoES(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de entrada y convertirlos a números
            if (double.TryParse(entradaNumero1.Text, out double numero1) &&
                double.TryParse(entradaNumero2.Text, out double numero2))
            {
                // Calcular los resultados
                double suma = numero1 + numero2;
                double resta = numero1 - numero2;
                double multiplicacion = numero1 * numero2;

                // Manejar la división por cero
                double division = numero2 != 0 ? numero1 / numero2 : double.NaN;

                // Mostrar los resultados en los campos de entrada correspondientes
                resultadoSuma.Text = suma.ToString();
                resultadoResta.Text = resta.ToString();
                resultadoMultiplicacion.Text = multiplicacion.ToString();
                resultadoDivision.Text = double.IsNaN(division) ? "Error: División por cero" : division.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si no se pueden convertir los valores a números
                DisplayAlert("Error", "Por favor, ingresa números válidos.", "OK");
            }
        }
    }
}
