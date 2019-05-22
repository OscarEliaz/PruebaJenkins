using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Modelo
{
    public class Cata
    {
        private int _idCata;
        private DateTime _fechaCata;
        private string _nombreCata;

        public Cata()
        {
            _idCata = 0;
            _fechaCata = DateTime.Now;
            _nombreCata = string.Empty;
        }
        public Cata(int idCata, DateTime fechaCata, string nombreCata)
        {
            _idCata = idCata;
            _fechaCata = fechaCata;
            _nombreCata = nombreCata;
        }

        public int IdCata { get => _idCata; set => _idCata = value; }
        public DateTime FechaCata { get => _fechaCata; set => _fechaCata = value; }
        public string NombreCata { get => _nombreCata; set => _nombreCata = value; }
    }
}
