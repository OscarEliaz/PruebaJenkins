using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IxCacaoApp.Controlador;
using IxCacaoApp.Modelo;
using IxCacaoApp.Vista;

namespace IxCacaoApp.Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AgregarProd ap = new AgregarProd();
                ap.Show();
            
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProd acp = new ActualizarProd();
            acp.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProd ep = new EliminarProd();
            ep.Show();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {

            int porc;
            int.TryParse(tb_porc.Text, out porc);
            
                if (porc <= 100)
                {



                    l_mensajes.Text = string.Empty;
                    ControladorProducto cp = new ControladorProducto();
                    int estado = cp.ConsultaProductos(cb_origen.Text, porc, cb_aroma.Text, cb_inclusion.Text, cb_choc.Text);
                    switch (estado)
                    {
                        case 1:
                            dgvProducto.Rows.Clear();

                            Producto p = new Producto();
                            List<Producto> listaProductos = new List<Producto>();
                            listaProductos = cp.obtenerDatosDeProductos();

                            for (int c = 0; c < listaProductos.Count; c++)
                            {
                                object[] registroProducto = new object[9];
                                registroProducto[0] = listaProductos[c].IdProd;
                                registroProducto[1] = listaProductos[c].NomProd;
                                registroProducto[2] = listaProductos[c].Origen;
                                registroProducto[3] = listaProductos[c].Porcentaje;
                                registroProducto[4] = listaProductos[c].Aroma;
                                registroProducto[5] = listaProductos[c].Inclusion;
                                registroProducto[6] = listaProductos[c].Chocolatero;
                                registroProducto[7] = listaProductos[c].Precio;
                                registroProducto[8] = listaProductos[c].Stock;
                                dgvProducto.Rows.Add(registroProducto);
                            }
                            break;
                        default:
                            l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                            break;
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe Ingresar un Porcentaje Hasta de 100%";
                }
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
