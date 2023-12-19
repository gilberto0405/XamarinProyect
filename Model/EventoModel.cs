using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Authentication.Model
{
    public class EventoModel : INotifyPropertyChanged
    {
        private int numero;
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string fechas;

        public int Numero
        {
            get => numero;

            set
            {
                numero = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get => nombre;

            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        public DateTime FechaInicio
        {
            get => fechaInicio;

            set
            {
                fechaInicio = value;
                OnPropertyChanged();
            }
        }

        public DateTime FechaFin
        {
            get => fechaFin;

            set
            {
                fechaFin = value;
                OnPropertyChanged();
            }
        }

        public string Fechas
        {
            get => fechas;

            set
            {
                fechas = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
