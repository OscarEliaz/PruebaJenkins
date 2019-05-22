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
    public partial class ReporteCatas : Form
    {
        public ReporteCatas()
        {
            InitializeComponent();
        }

        public void SetCataId(int cataId)
        {
            tb_idcata.Text = cataId.ToString();
        }
        private void ReporteCatas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.sp_Reportes_GenerarReporteCata' Puede moverla o quitarla según sea necesario.
            this.sp_Reportes_GenerarReporteCataTableAdapter.Fill(this.DataSetPrincipal.sp_Reportes_GenerarReporteCata, Convert.ToInt32(tb_idcata.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
