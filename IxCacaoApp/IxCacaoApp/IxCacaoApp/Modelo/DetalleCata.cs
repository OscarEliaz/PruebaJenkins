using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Modelo
{
    public class DetalleCata
    {
        private int _idDetalleCata;
        private Producto _producto;
        private Cata _cata;
         
        public DetalleCata()
        {
            _idDetalleCata = 0;
            _producto = new Producto();
            _cata = new Cata();
        }

        public int IdDetalleCata { get => _idDetalleCata; set => _idDetalleCata = value; }
        public Cata Cata { get => _cata; set => _cata = value; }
        internal Producto Producto { get => _producto; set => _producto = value; }
    }
}
