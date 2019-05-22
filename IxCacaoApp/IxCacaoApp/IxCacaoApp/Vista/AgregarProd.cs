using IxCacaoApp.Controlador;
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
    public partial class AgregarProd : Form
    {
        ControladorProducto cp = new ControladorProducto();
        public AgregarProd()
        {
            InitializeComponent();
        }

        private void AgregarProd_Load(object sender, EventArgs e)
        {
            tb_idProd.Focus();
            l_mensajes.Text = string.Empty;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void b_Guardar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            if(tb_idProd.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Id de producto";
                tb_idProd.Focus();
            }
            else
            {
                int idProd;
                if(int.TryParse(tb_idProd.Text, out idProd))
                {
                    if(idProd > 0)
                    {
                        if(tb_nombre.Text.Equals(""))
                        {
                            l_mensajes.Text = "Ingresar nombre al producto";
                            tb_nombre.Focus();
                        }
                        else
                        {
                            if(cb_origen.SelectedIndex > 0)
                            {
                                if (tb_porc.Text.Equals(""))
                                {
                                    l_mensajes.Text = "Ingresar un Porcentaje";
                                    tb_porc.Focus();
                                }
                                else
                                {
                                    int porcentaje;
                                    if (int.TryParse(tb_porc.Text, out porcentaje))
                                    {
                                        if (porcentaje > 0 && porcentaje<=100)
                                        {
                                            if (cb_aroma.SelectedIndex > 0)
                                            {
                                                if (cb_inclusion.SelectedIndex > 0)
                                                {
                                                    if (cb_choc.SelectedIndex > 0)
                                                    {
                                                        if (tb_preUn.Text.Equals(""))
                                                        {
                                                            l_mensajes.Text = "Debe ingresar un precio";
                                                            tb_preUn.Focus();
                                                        }
                                                        else
                                                        {
                                                            int precio;
                                                            if (int.TryParse(tb_preUn.Text, out precio))
                                                            {
                                                                if (precio > 0)
                                                                {
                                                                    if (tb_stock.Text.Equals(""))
                                                                    {
                                                                        l_mensajes.Text = "Debe ingresar stock del producto";
                                                                        tb_stock.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        int stock;
                                                                        if (int.TryParse(tb_stock.Text, out stock))
                                                                        {
                                                                            if (stock > 0)
                                                                            {
                                                                                int re = cp.existeProducto(idProd);
                                                                                switch (re)
                                                                                {
                                                                                    case 0:
                                                                                        int estado = cp.AgregarProducto(idProd, tb_nombre.Text, cb_origen.Text, porcentaje, cb_aroma.Text, cb_inclusion.Text, cb_choc.Text, precio, stock);
                                                                                        switch (estado)
                                                                                        {
                                                                                            case 1:
                                                                                                l_mensajes.Text = "Datos de producto guardados";
                                                                                                Limpiar();
                                                                                                break;
                                                                                            default:
                                                                                                l_mensajes.Text = "No existe Conexion con la base de datos";
                                                                                                break;
                                                                                        }
                                                                                        break;
                                                                                    case 1:
                                                                                        l_mensajes.Text = "Datos del Producto Ya existen en BD";
                                                                                        break;
                                                                                    default:
                                                                                        l_mensajes.Text = "Error al conectarse a BD. Contacte a ...";
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                l_mensajes.Text = "Debe ingresar un numero mayor o igual a cero";
                                                                                tb_stock.Focus();
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            l_mensajes.Text = "Debe ingresar un numero mayor a cero";
                                                                            tb_stock.Focus();
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    l_mensajes.Text = "Debe ingresar un precio mayor a 0";
                                                                    tb_preUn.Focus();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                l_mensajes.Text = "Debe ingresar un numero entero";
                                                                tb_preUn.Focus();
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        l_mensajes.Text = "Debe ingresar un chocolatero";
                                                        cb_choc.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    l_mensajes.Text = "Debe ingresar una Inclusion";
                                                    cb_inclusion.Focus();
                                                }
                                            }
                                            else
                                            {
                                                l_mensajes.Text = "Debe seleccionar un aroma";
                                                cb_aroma.Focus();
                                            }
                                        }
                                        else
                                        {
                                            l_mensajes.Text = "Debe ingresar un Porcentaje mayor a 0 o Menor a 100";
                                            tb_porc.Focus();
                                        }
                                    }
                                    else
                                    {
                                        l_mensajes.Text = "Debe ingresar un numero entero";
                                        tb_porc.Focus();
                                    }
                                }
                            }
                            else
                            {
                                l_mensajes.Text = "Debe ingresar un Origen";
                                cb_origen.Focus();
                            }
                        }
                    }
                    else
                    {
                        l_mensajes.Text = "Debe ingresar un numero mayor a 0";
                        tb_idProd.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe ingresar un numero entero";
                    tb_idProd.Focus();
                }
            }            
        }

        private void b_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Limpiar()
        {
            tb_idProd.Text = string.Empty;
            tb_nombre.Text = string.Empty;
            cb_origen.SelectedIndex = 0;
            tb_porc.Text = string.Empty;
            cb_aroma.SelectedIndex = 0;
            cb_inclusion.SelectedIndex = 0;
            cb_choc.SelectedIndex = 0;
            tb_preUn.Text = string.Empty;
            tb_stock.Text = string.Empty;
            l_mensajes.Text = string.Empty;
            tb_idProd.Focus();
        }

        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            Limpiar();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProd acp = new ActualizarProd();
            acp.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProd ap = new AgregarProd();
            ap.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void b_Restablecer_Click_1(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            Limpiar();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tb_preUn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_choc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_inclusion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_aroma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tb_porc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_origen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void l_mensajes_Click(object sender, EventArgs e)
        {

        }

        private void tb_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_idProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

