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
    public partial class fmrDetalleCata : Form
    {
        private static fmrDetalleCata _instancia = null;

        public fmrDetalleCata()
        {
            InitializeComponent();
            mostrarProductos();
            
        }

        private void fmrDetalleCata_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        public static fmrDetalleCata GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new fmrDetalleCata();
            }
            return _instancia;
        }
        
        internal void SetCata(Cata cata)
        {
            txt_idcata.Text = cata.IdCata.ToString();
            txt_fecha.Text = cata.FechaCata.ToString();
            txt_nom.Text = cata.NombreCata.ToString();
        }

        #region borrar datos
        private void Limpiar()
        {
            txt_idprod.Text = string.Empty;
            txt_nombre.Text = string.Empty;

        }

        #endregion

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = string.Empty;
            if (txt_idprod.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar id de Producto";
                txt_idprod.Focus();
            }
            else
            {
                int idProd;
                if (int.TryParse(txt_idprod.Text, out idProd))
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

                                int estado = cp.ConsultarUnProducto(idProd); ;
                                switch (estado)
                                {
                                    case 1:
                                        Producto p = new Producto();
                                        p = cp.obtenerDatosProducto();
                                        txt_nombre.Text = p.NomProd;
                                        bt_guardar.Enabled = true;
                                        bt_eliminar.Enabled = true;
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
                        txt_idprod.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Ingresar id de Producto numerico entero";
                    txt_idprod.Focus();
                }
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            int idcata;
            int.TryParse(txt_idcata.Text, out idcata);
            
            if (txt_idprod.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Id de producto";
            }
            else
            {
                int idprod;
                if (int.TryParse(txt_idprod.Text, out idprod))
                {
                    if (idprod > 0)
                    {
                                ControladorDetalleCata cdc = new ControladorDetalleCata();
                                int re = cdc.existeDetalleCata(idprod);
                                switch (re)
                                {
                                    case 0:
                                        int estado = cdc.AgregarDetalleCata(idcata, idprod);
                                        switch (estado)
                                        {
                                            case 1:
                                                l_mensajes.Text = "Producto Agregado a Cata ";
                                                Limpiar();
                                                mostrarProductos();                                             
                                                break;
                                            default:
                                                l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
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
                        l_mensajes.Text = "Debe ingresar un numero mayor a 0";
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe ingresar un numero entero";
                }
            }
        }

        private void mostrarProductos()
        {
            int id_cata;
            int.TryParse(txt_idcata.Text, out id_cata);
            l_mensajes.Text = string.Empty;
            ControladorDetalleCata cdc = new ControladorDetalleCata();
            int estado = cdc.ConsultarTodosLosProductos(id_cata);
            switch (estado)
            {
                case 1:
                    dgvDetalleCata.Rows.Clear();
                    DetalleCata dc = new DetalleCata();
                    List<DetalleCata> listaLosProductos = new List<DetalleCata>();
                    listaLosProductos = cdc.obtenerDatostodasProducto();
                    for (int c = 0; c < listaLosProductos.Count; c++)
                    {
                        object[] registroPrCata = new object[11];
                        registroPrCata[0] = listaLosProductos[c].Cata.IdCata;
                        registroPrCata[1] = listaLosProductos[c].Cata.FechaCata;
                        registroPrCata[2] = listaLosProductos[c].Cata.NombreCata;
                        registroPrCata[3] = listaLosProductos[c].IdDetalleCata;
                        registroPrCata[4] = listaLosProductos[c].Producto.IdProd;
                        registroPrCata[5] = listaLosProductos[c].Producto.NomProd;
                        registroPrCata[6] = listaLosProductos[c].Producto.Origen;
                        registroPrCata[7] = listaLosProductos[c].Producto.Porcentaje;
                        registroPrCata[8] = listaLosProductos[c].Producto.Aroma;
                        registroPrCata[9] = listaLosProductos[c].Producto.Inclusion;
                        registroPrCata[10] = listaLosProductos[c].Producto.Chocolatero;
                        dgvDetalleCata.Rows.Add(registroPrCata);
                    }
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_idprod.Text.Equals(""))
            {
                l_mensajes.Text = "Debe ingresar un id";
            }
            else
            {
                int idProd;
                if (int.TryParse(txt_idprod.Text, out idProd))
                {
                    if (idProd > 0)
                    {

                        ControladorDetalleCata cdc = new ControladorDetalleCata();
                        int estado = cdc.EliminarDetalleCata(idProd);
                        switch (estado)
                        {
                            case 1:
                                l_mensajes.Text = "Datos del Producto Eliminados";
                                Limpiar();
                                mostrarProductos();
                                bt_eliminar.Enabled = false;
                                bt_guardar.Enabled = false;
                                break;
                            default:
                                l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                                break;
                        }
                    }
                    else
                    {
                        l_mensajes.Text = "ingresar id como numero mayor a 0";
                    }
                }
                else
                {
                    l_mensajes.Text = "Ingresar id como entero";
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            ReporteCatas reportecatas = new ReporteCatas();
            reportecatas.SetCataId(Convert.ToInt32(txt_idcata.Text));
            reportecatas.ShowDialog();
        }
    }
}
