using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Modelo
{
    public class DetalleBoleta
    {
        private int _idDetBta;
        private Producto _producto;
        private Boleta _boleta;
        private int _cantidad;
        private int _precioUnitario;

        public DetalleBoleta()
        {
            _idDetBta = 0;
            _producto = new Producto();
            _boleta = new Boleta();
            _cantidad = 0;
            _precioUnitario = 0;
        }
        

        public int IdDetBta { get => _idDetBta; set => _idDetBta = value; }
        public Boleta Boleta { get => _boleta; set => _boleta = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        internal Producto Producto { get => _producto; set => _producto = value; }
    }
}
