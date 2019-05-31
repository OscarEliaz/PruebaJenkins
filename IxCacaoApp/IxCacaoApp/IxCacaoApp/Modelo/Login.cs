using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Modelo
{
    class Login
    {
        private int _idUsuario;
        private string _nombreUsuario;
        private string _contraseña;
        private int _algo;

        Login()
        {
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;
        }
        Login(int idUsuario, string nombreUsuario, string contraseña)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }

        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id Usuario     : {0} \n", _idUsuario);
            sb.AppendFormat("Nombre Usuario         : {0} \n", _nombreUsuario);
            sb.AppendFormat("Contraseña          : {0} \n", _contraseña);
            return sb.ToString();
        }
    }
}
