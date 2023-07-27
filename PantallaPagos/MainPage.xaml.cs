using PantallaPagos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PantallaPagos
{
    public partial class MainPage : ContentPage
    {
        public Pagos pago;

        public MainPage()
        {
            InitializeComponent();
            pago = new Pagos();
            BindingContext = pago;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Aquí se puede navegar hacia atrás a la página anterior
            Navigation.PopAsync();
        }

        private void OnPagarButtonClicked(object sender, EventArgs e)
        {
            // Verificar si se han ingresado todos los datos requeridos y si se ha seleccionado un método de pago
            if (!string.IsNullOrEmpty(pago.Nombres) &&
                !string.IsNullOrEmpty(pago.CorreoElectronico) &&
                !string.IsNullOrEmpty(pago.NumeroTelefonico) &&
                !string.IsNullOrEmpty(pago.CedulaIdentidad) &&
                (TarjetaRadio.IsChecked || GiftCardRadio.IsChecked) &&
                TerminosRadioButton.IsChecked)
            {
                // Aquí se puede realizar el proceso de pago y mostrar una confirmación o mensaje de éxito
                // Por ejemplo, mostrar un mensaje emergente con los datos de pago
                string metodoPago = TarjetaRadio.IsChecked ? "Tarjeta Crédito/Debito" : "GiftCard";
                string mensaje = $"Pago realizado:\nNombres: {pago.Nombres}\nCorreo: {pago.CorreoElectronico}\nTeléfono: {pago.NumeroTelefonico}\nCédula: {pago.CedulaIdentidad}\nMétodo de Pago: {metodoPago}";
                DisplayAlert("Pago Exitoso", mensaje, "Aceptar");
            }
            else
            {
                // Si faltan datos o no se han aceptado los términos, mostrar un mensaje de error
                DisplayAlert("Error", "Por favor, complete todos los campos y acepte los términos para continuar.", "Aceptar");
            }
        }
    }
}
