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
    public partial class ActualizarProd : Form
    {
        public ActualizarProd()
        {
            InitializeComponent();
        }

        private void b_Guardar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            if (tb_idProd.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Id de producto";
                tb_idProd.Focus();
            }
            else
            {
                int idProd;
                if (int.TryParse(tb_idProd.Text, out idProd))
                {
                    if (idProd > 0)
                    {
                        if (tb_nombre.Text.Equals(""))
                        {
                            l_mensajes.Text = "Ingresar nombre al producto";
                            tb_nombre.Focus();
                        }
                        else
                        {
                            if (cb_origen.SelectedIndex > 0)
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
                                        if (porcentaje > 0)
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
                                                                            if (stock >= 0)
                                                                            {
                                                                                ControladorProducto cp = new ControladorProducto();
                                                                                int estado = cp.ActualizarProducto(idProd, tb_nombre.Text, cb_origen.Text, porcentaje, cb_aroma.Text, cb_inclusion.Text, cb_choc.Text, precio, stock);
                                                                                switch (estado)
                                                                                {
                                                                                    case 1:
                                                                                        l_mensajes.Text = "Datos del Producto Actualizados";
                                                                                        deshabilitar();
                                                                                        Limpiar();
                                                                                        break;
                                                                                    default:
                                                                                        l_mensajes.Text = "No existe Conexion con la base de datos";
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
                                            l_mensajes.Text = "Debe ingresar un numero mayor a 0";
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
        private void ActualizarProd_Load(object sender, EventArgs e)
        {
            deshabilitar();
            l_mensajes.Text = string.Empty;
        }

        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            Limpiar();
            deshabilitar();
            tb_idProd.Focus();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void habilitar()
        {
            tb_idProd.Enabled = false;
            tb_nombre.Enabled = true;
            cb_origen.Enabled = true;
            tb_porc.Enabled = true;
            cb_aroma.Enabled = true;
            cb_inclusion.Enabled = true;
            cb_choc.Enabled = true;
            tb_preUn.Enabled = true;
            tb_stock.Enabled = true;
            bt_consultar.Enabled = false;
            b_Guardar.Enabled = true;
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
            b_Guardar.Enabled = false;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_preUn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
