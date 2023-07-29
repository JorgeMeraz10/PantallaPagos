using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PantallaPagos.Models
{
    public class Pagos : INotifyPropertyChanged
    {
       // public string Nombres { get; set; }
       // public string CorreoElectronico { get; set; }
       // public string NumeroTelefonico { get; set; }
      //  public string CedulaIdentidad { get; set; }

        // Propiedad para el identificador del pago (ID)
        private int id;
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value); // Se utiliza SetProperty para asignar y notificar el cambio
        }

        // Propiedad para los nombres del pagador
        private string nombres;
        public string Nombres
        {
            get => nombres;
            set => SetProperty(ref nombres, value); // Se utiliza SetProperty para asignar y notificar el cambio
        }

        // Propiedad para el correo electrónico del pagador
        private string correoElectronico;
        public string CorreoElectronico
        {
            get => correoElectronico;
            set => SetProperty(ref correoElectronico, value); // Se utiliza SetProperty para asignar y notificar el cambio
        }

        // Propiedad para el número telefónico del pagador
        private string numeroTelefonico;
        public string NumeroTelefonico
        {
            get => numeroTelefonico;
            set => SetProperty(ref numeroTelefonico, value); // Se utiliza SetProperty para asignar y notificar el cambio
        }

        // Propiedad para la cédula de identidad del pagador
        private string cedulaIdentidad;
        public string CedulaIdentidad
        {
            get => cedulaIdentidad;
            set => SetProperty(ref cedulaIdentidad, value); // Se utiliza SetProperty para asignar y notificar el cambio
        }

        // Evento que notifica a la interfaz de usuario cuando cambia alguna propiedad
        public event PropertyChangedEventHandler PropertyChanged;

        // Método que actualiza el valor de una propiedad y notifica el cambio a la interfaz de usuario
        protected void SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return;

            backingStore = value;
            OnPropertyChanged(propertyName); // Se invoca el evento PropertyChanged
        }

        // Método que invoca el evento PropertyChanged para notificar el cambio en una propiedad
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
