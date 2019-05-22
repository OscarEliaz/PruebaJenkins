using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IxCacaoApp
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }
        public void SetVentaId(int id_venta)
        {
            txt_idventa.Text = id_venta.ToString();
        }
        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.sp_Reportes_GenerarReporteVenta' Puede moverla o quitarla según sea necesario.
            this.sp_Reportes_GenerarReporteVentaTableAdapter.Fill(this.DataSetPrincipal.sp_Reportes_GenerarReporteVenta, Convert.ToInt32(txt_idventa.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
