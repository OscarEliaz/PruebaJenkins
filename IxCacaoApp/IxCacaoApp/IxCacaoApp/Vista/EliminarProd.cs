using IxCacaoApp.Controlador;
using IxCacaoApp.Modelo;
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
    public partial class EliminarProd : Form
    {
        public EliminarProd()
        {
            InitializeComponent();
        }

        private void EliminarProd_Load(object sender, EventArgs e)
        {
            deshabilitar();
        }

        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            int idProd = Int32.Parse(tb_idProd.Text);
            ControladorProducto cp = new ControladorProducto();
            int estado = cp.EliminarProducto(idProd);
            switch (estado)
            {
                case 1:
                    l_mensajes.Text = "Datos del Producto Eliminados";
                    deshabilitar();
                    Limpiar();
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
            tb_idProd.Focus();
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
            deshabilitar();
        }
        private void habilitar()
        {
            tb_idProd.Enabled = false;
            tb_nombre.Enabled = false;
            cb_origen.Enabled = false;
            tb_porc.Enabled = false;
            cb_aroma.Enabled = false;
            cb_inclusion.Enabled = false;
            cb_choc.Enabled = false;
            tb_preUn.Enabled = false;
            tb_stock.Enabled = false;
            bt_consultar.Enabled = false;
            b_Eliminar.Enabled = true;
            b_Restablecer.Enabled = true;

        }
        private void deshabilitar()
        {
            tb_idProd.Enabled = true;
            tb_nombre.Enabled = false;
            cb_origen.Enabled = false;
            tb_porc.Enabled = false;
            cb_aroma.Enabled = false;
            cb_inclusion.Enabled = false;
            cb_choc.Enabled = false;
            tb_preUn.Enabled = false;
            tb_stock.Enabled = false;
            bt_consultar.Enabled = true;
            b_Eliminar.Enabled = false;
            b_Restablecer.Enabled = false;

        }
        private void bt_consultar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            if (tb_idProd.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar id de Producto";
                tb_idProd.Focus();
            }
            else
            {
                int idProd;
                if (int.TryParse(tb_idProd.Text, out idProd))
                {
                    if (idProd > 0)
                    {
                        ControladorProducto cp = new ControladorProducto();
                        int res = cp.existeProducto(idProd);
                        switch (res)
                        {
                            case 0:
                                l_mensajes.Text = "Datos del Producto NO existen en BD";
                                break;
                            case 1:
                                int estado = cp.ConsultarUnProducto(idProd);
                                switch (estado)
                                {
                                    case 1:
                                        Producto p = new Producto();
                                        p = cp.obtenerDatosProducto();
                                        tb_nombre.Text = p.NomProd;
                                        cb_origen.Text = p.Origen;
                                        tb_porc.Text = p.Porcentaje.ToString();
                                        cb_aroma.Text = p.Aroma;
                                        cb_inclusion.Text = p.Inclusion;
                                        cb_choc.Text = p.Chocolatero;
                                        tb_preUn.Text = p.Precio.ToString();
                                        tb_stock.Text = p.Stock.ToString();
                                        habilitar();
                                        break;
                                    default:
                                        l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                                        break;
                                }
                                break;
                            default:
                                l_mensajes.Text = "Error al conectarse a BD. Contacte a ...";
                                break;

                        }
                    }
                    else
                    {
                        l_mensajes.Text = "Ingresar id de Producto > 0";
                        tb_idProd.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Ingresar id de Producto numerico entero";
                    tb_idProd.Focus();
                }
            }
        }
    }
}
