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

namespace IxCacaoApp.Vista
{
    public partial class DetalleVenta : Form
    {
        private static DetalleVenta _instancia = null;

        public DetalleVenta()
        {
            InitializeComponent();
            mostrarProductos();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        public static DetalleVenta GetInstance()
        {
            if (_instancia==null)
            {
                _instancia = new DetalleVenta();
            }
            return _instancia;
        }

        internal void SetVenta(Boleta boleta)
        {
            txt_idventa.Text = boleta.Idboleta.ToString();
            txt_fecha.Text = boleta.Fechaboleta.ToString();
            txt_nrodoc.Text = boleta.NumeroDocumento.ToString();
        }

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
                        ControladorDetalleBoleta cdb = new ControladorDetalleBoleta();
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
                                        txt_stock.Text = p.Stock.ToString();
                                        txt_preciounit.Text = p.Precio.ToString();
                                        txt_cantidad.Value = 1;
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
            int idventa;
            int.TryParse(txt_idventa.Text, out idventa);
            int preciounit;
            int.TryParse(txt_preciounit.Text, out preciounit);
            
            
            if (txt_idprod.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Id de producto";
            }
            else
            {
                int idprod;
                if(int.TryParse(txt_idprod.Text, out idprod))
                {
                    if(idprod > 0)
                    {
                        
                        if(txt_cantidad.Value > 0)
                        {

                            if (txt_cantidad.Value < Convert.ToInt32(txt_stock.Text))
                            {

                                ControladorDetalleBoleta cdb = new ControladorDetalleBoleta();
                                int re = cdb.existeDetalleProducto(idprod);
                                switch (re) {
                                    case 0:
                                int estado = cdb.AgregarDetalleBoleta(idventa, idprod, Convert.ToInt32(txt_cantidad.Value), preciounit);
                                switch (estado)
                                {
                                    case 1:
                                        l_mensajes.Text = "Datos de Boleta guardada";
                                                Limpiar();
                                                mostrarProductos();
                                                quitarProducto();
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
                                l_mensajes.Text = "Cantidad Supera el Stock";
                            }
                        }
                        else
                        {
                            l_mensajes.Text = "Debe ingresar una cantidad mayor a 0";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        #region borrar datos
        private void Limpiar()
        {
            txt_idprod.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_cantidad.Text = string.Empty;
            txt_preciounit.Text = string.Empty;
            txt_stock.Text = string.Empty;

        }
        #endregion

        private void txt_cantidad_ValueChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void mostrarProductos()
        {
            int id_venta;
            int.TryParse(txt_idventa.Text, out id_venta);
            l_mensajes.Text = string.Empty;
            ControladorDetalleBoleta cdb = new ControladorDetalleBoleta();
            int estado = cdb.ConsultarTodosLosProductos(id_venta);
            switch (estado)
            {
                case 1:
                    dgvDetalleVenta.Rows.Clear();
                    DetalleBoleta db = new DetalleBoleta();
                    List<DetalleBoleta> listaLosProductos = new List<DetalleBoleta>();
                    listaLosProductos = cdb.obtenerDatostodasProducto();
                    for (int c = 0; c < listaLosProductos.Count; c++)
                    {
                        object[] registroBoleta = new object[8];
                        registroBoleta[0] = listaLosProductos[c].Boleta.Idboleta;
                        registroBoleta[1] = listaLosProductos[c].Boleta.Fechaboleta;
                        registroBoleta[2] = listaLosProductos[c].Boleta.NumeroDocumento;
                        registroBoleta[3] = listaLosProductos[c].IdDetBta;
                        registroBoleta[4] = listaLosProductos[c].Producto.IdProd;
                        registroBoleta[5] = listaLosProductos[c].Producto.NomProd;
                        registroBoleta[6] = listaLosProductos[c].Cantidad;
                        registroBoleta[7] = listaLosProductos[c].PrecioUnitario;
                        dgvDetalleVenta.Rows.Add(registroBoleta);
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
            else {
                int idProd;
                if (int.TryParse(txt_idprod.Text, out idProd))
                {
                    if (idProd > 0)
                    {

                        ControladorDetalleBoleta cdb = new ControladorDetalleBoleta();
                        int estado = cdb.EliminarDetalleBoleta(idProd);
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

        private void quitarProducto()
        {
            int idProd;
            int.TryParse(txt_idprod.Text, out idProd);
            ControladorDetalleBoleta cdb = new ControladorDetalleBoleta();
            int estado = cdb.reducirStock(idProd, Convert.ToInt32(txt_cantidad.Value));
            switch (estado)
            {
                case 1:
                    l_mensajes.Text = "Datos del Producto Eliminados";
                    mostrarProductos();
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            ReporteVentas reporteVentas = new ReporteVentas();
            reporteVentas.SetVentaId(Convert.ToInt32(txt_idventa.Text));
            reporteVentas.ShowDialog();
        }
    }
}
