using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Modelo
{
    public class Boleta
    {
        private int _idboleta;
        private DateTime _fechaboleta;
        private string _numeroDocumento;

        public Boleta()
        {
            _idboleta = 0;
            _fechaboleta = DateTime.Now;
            _numeroDocumento = string.Empty;
        }
        public Boleta(int idboleta, DateTime fechaboleta, string numeroDocumento)
        {
            _idboleta = idboleta;
            _fechaboleta = fechaboleta;
            _numeroDocumento = numeroDocumento;
        }

        public int Idboleta { get => _idboleta; set => _idboleta = value; } 
        public string NumeroDocumento { get => _numeroDocumento; set => _numeroDocumento = value; }
        public DateTime Fechaboleta { get => _fechaboleta; set => _fechaboleta = value; }
    }
}
