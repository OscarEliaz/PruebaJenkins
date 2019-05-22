using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Modelo
{
    class Producto
    {
        private int _idProd;
        private string _nomProd;
        private string _origen;
        private int _porcentaje;
        private string _aroma;
        private string _inclusion;
        private string _chocolatero;
        private int _precio;
        private int _stock;

        public Producto()
        {
            _idProd = 0;
            _nomProd = string.Empty;
            _origen = string.Empty;
            _porcentaje = 0;
            _inclusion = string.Empty;
            _chocolatero = string.Empty;
            _precio = 0;
            _stock = 0;
        }
        public Producto(int idProd, string nomProd, string origen, int porcentaje, string aroma, string inclusion, string chocolatero, int precio, int stock)
        {
            _idProd = idProd;
            _nomProd = nomProd;
            _origen = origen;
            _porcentaje = porcentaje;
            _inclusion = inclusion;
            _chocolatero = chocolatero;
            _precio = precio;
            _stock = stock;
        }

        public int IdProd { get => _idProd; set => _idProd = value; }
        public string NomProd { get => _nomProd; set => _nomProd = value; }
        public string Origen { get => _origen; set => _origen = value; }
        public int Porcentaje { get => _porcentaje; set => _porcentaje = value; }
        public string Aroma { get => _aroma; set => _aroma = value; }
        public string Inclusion { get => _inclusion; set => _inclusion = value; }
        public string Chocolatero { get => _chocolatero; set => _chocolatero = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Datos Producto \n\n");
            sb.AppendFormat("Id Producto     : {0} \n", _idProd);
            sb.AppendFormat("Nombre          : {0} \n", _nomProd);
            sb.AppendFormat("Origen          : {0} \n", _origen);
            sb.AppendFormat("Porcentaje      : {0} \n", _porcentaje);
            sb.AppendFormat("Aroma           : {0} \n", _aroma);
            sb.AppendFormat("Inclusion       : {0} \n", _inclusion);
            sb.AppendFormat("Chocolatero     : {0} \n", _chocolatero);
            sb.AppendFormat("Precio          : {0:#.#} \n", _precio);
            sb.AppendFormat("Stock           : {0} \n", _stock);
            return sb.ToString();
        }
    }
}
