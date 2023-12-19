using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Text;

namespace Authentication.Model
{
    public class ClienteModel : INotifyPropertyChanged
    {
        private string id;
        private string nombreUsuario;
        private string apellidoUsuario;
        private string telefonoUsuario;
        private string cedulaUsuario;
        private string direccionUsuario;
        private string emailUsuario;
        private string contrasenaUsuario;

        public string ID
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string NOMBRE_USUARIO
        {
            get => nombreUsuario;
            set
            {
                nombreUsuario = value;
                OnPropertyChanged();
            }
        }
        public string APELLIDO_USUARIO
        {
            get => apellidoUsuario;
            set
            {
                apellidoUsuario = value;
                OnPropertyChanged();
            }
        }

        public string TELEFONO_USUARIO
        {
            get => telefonoUsuario;
            set
            {
                telefonoUsuario = value;
                OnPropertyChanged();
            }
        }

        public string CEDULA_USUARIO
        {
            get => cedulaUsuario;
            set
            {
                cedulaUsuario = value;
                OnPropertyChanged();
            }
        }

        public string DIRECCION_USUARIO
        {
            get => direccionUsuario;
            set
            {
                direccionUsuario = value;
                OnPropertyChanged();
            }
        }

        public string EMAIL_USUARIO
        {
            get => emailUsuario;
            set
            {
                emailUsuario = value;
                OnPropertyChanged();
            }
        }
        public string CONTRASENA_USUARIO
        {
            get => contrasenaUsuario;
            set
            {
                contrasenaUsuario = value;
                OnPropertyChanged();
            }
        }

        /** Notificar ***/
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
