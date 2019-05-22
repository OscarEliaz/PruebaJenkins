using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IxCacaoApp.Vista
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void bt_gestion_Click(object sender, EventArgs e)
        {
            cb_submenu.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_submenu.Visible = false;
            abrirFormsHija(new AgregarProd());
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            cb_submenu.Visible = false;
            abrirFormsHija(new ActualizarProd());
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            cb_submenu.Visible = false;
            abrirFormsHija(new EliminarProd());
        }

        private void bt_cont_Click(object sender, EventArgs e)
        {
            cb_submenu.Visible = false;
            abrirFormsHija(new GestionUsuario());
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            abrirFormsHija(new Menu());
        }

        private void bt_venta_Click(object sender, EventArgs e)
        {
            abrirFormsHija(new Venta());
        }

        private void bt_cata_Click(object sender, EventArgs e)
        {
            abrirFormsHija(new fmrCata());
        }

        private void abrirFormsHija(object FormsHija)
        {
            if (this.pl_vistas.Controls.Count > 0)
                this.pl_vistas.Controls.RemoveAt(0);
            Form vw = FormsHija as Form;
            vw.TopLevel = false;
            vw.Dock = DockStyle.Fill;
            this.pl_vistas.Controls.Add(vw);
            this.pl_vistas.Tag = vw;
            vw.Show();
        }

        private void bt_CrSesion_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
