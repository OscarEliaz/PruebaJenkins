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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            deshabilitar();
            mostrarBoletas();


    }
        private void Venta_Load(object sender, EventArgs e)
        {
            mostrarBoletas();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (txt_fecha.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Fecha";
                
            }
            else
            {
                 if (txt_nrodoc.Text.Equals(""))
                {
                    l_mensajes.Text = "Ingresar Numero Documento";
                }                    
                else
                {
                    ControladorBoleta cb = new ControladorBoleta();
                            int estado = cb.AgregarBoleta(txt_fecha.Value, txt_nrodoc.Text);
                            switch (estado)
                            {
                                case 1:
                                    l_mensajes.Text = "Datos de Boleta guardada";
                                    mostrarBoletas();
                                    Limpiar();
                                    deshabilitar();
                            break;
                                default:
                                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                                    break;
                            }
                            
                            
                    }
                    
            }
        }

        #region Habilitar y deshabilitar
        private void deshabilitar()
        {
            txt_idventa.Enabled = true;
            txt_fecha.Enabled = false;
            txt_nrodoc.Enabled = false;
            bt_nuevo.Enabled = true;
            bt_consultar.Enabled = true;
            bt_guardar.Enabled = false;
            bt_actualizar.Enabled = false;
            bt_eliminar.Enabled = false;
        }
        private void habilitarGuardar()
        {
            txt_idventa.Enabled = false;
            txt_fecha.Enabled = true;
            txt_nrodoc.Enabled = true;
            bt_nuevo.Enabled = false;
            bt_consultar.Enabled = false;
            bt_guardar.Enabled = true;
            bt_actualizar.Enabled = false;
            bt_eliminar.Enabled = false;
        }
        private void habilitarActualizar()
        {
            txt_idventa.Enabled = false;
            txt_fecha.Enabled = true;
            txt_nrodoc.Enabled = true;
            bt_nuevo.Enabled = false;
            bt_consultar.Enabled = false;
            bt_guardar.Enabled = false;
            bt_actualizar.Enabled = true;
            bt_eliminar.Enabled = true;
        }

        #endregion

        #region borrar datos
        private void Limpiar()
        {
            txt_idventa.Text = string.Empty;
            txt_fecha.Text = string.Empty;
            txt_nrodoc.Text = string.Empty;
            
        }
        #endregion

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            habilitarGuardar();
            Limpiar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            deshabilitar();
            mostrarBoletas();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            
            l_mensajes.Text = string.Empty;
            if (txt_idventa.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar id de Producto";
                
            }
            else
            {
                int idboleta;
                if (int.TryParse(txt_idventa.Text, out idboleta))
                {
                    if (idboleta > 0)
                    {
                        ControladorBoleta cb = new ControladorBoleta();
                        int res = cb.existBoleta(idboleta);
                        switch (res)
                        {
                            case 0:
                                l_mensajes.Text = "Datos del Producto NO existen en BD";
                                break;
                            case 1:
                                int estado = cb.ConsultarUnBoleta(idboleta);
                                switch (estado)
                                {
                                    case 1:
                                        Boleta b = new Boleta();
                                        b = cb.obtenerDatosBoleta();
                                        txt_idventa.Text =b.Idboleta.ToString();
                                        txt_fecha.Text = b.Fechaboleta.ToString();
                                        txt_nrodoc.Text = b.NumeroDocumento;

                                        dgvVenta.Rows.Clear();
                                        object[] registroBoleta = new object[3];
                                        registroBoleta[0] = b.Idboleta;
                                        registroBoleta[1] = b.Fechaboleta;
                                        registroBoleta[2] = b.NumeroDocumento;
                                        dgvVenta.Rows.Add(registroBoleta);
                                        habilitarActualizar();
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
                        txt_idventa.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Ingresar id de Producto numerico entero";
                    txt_idventa.Focus();
                }
            }
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_idventa.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresa un Id";
            }
            else
            {
                int idBoleta;
                if (int.TryParse(txt_idventa.Text, out idBoleta))
                {
                    if (idBoleta > 0)
                    {

                        if (txt_fecha.Text.Equals(""))
                        {
                            l_mensajes.Text = "Ingresar Fecha";

                        }
                        else
                        {
                            if (txt_nrodoc.Text.Equals(""))
                            {
                                l_mensajes.Text = "Ingresar Numero Documento";
                            }
                            else
                            {
                                ControladorBoleta cb = new ControladorBoleta();
                                int estado = cb.ActualizarBoleta(idBoleta, txt_fecha.Value, txt_nrodoc.Text);
                                switch (estado)
                                {
                                    case 1:
                                        l_mensajes.Text = "Datos de Boleta Actualizados";
                                        mostrarBoletas();
                                        break;
                                    default:
                                        l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                                        break;
                                }
                                

                            }

                        }
                    }
                    else
                    {
                        l_mensajes.Text = "Debe ingresar un precio mayor a 0";
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

        private void mostrarBoletas()
        {
            l_mensajes.Text = string.Empty;
            ControladorBoleta cb = new ControladorBoleta();
            int estado = cb.ConsultarTodasBoletas();
            switch (estado)
            {
                case 1:
                    dgvVenta.Rows.Clear();
                    Boleta b = new Boleta();
                    List<Boleta> listaboletas = new List<Boleta>();
                    listaboletas = cb.obtenerDatostodasBoletas();
                    for (int c = 0; c < listaboletas.Count; c++)
                    {
                        object[] registroBoleta = new object[3];
                        registroBoleta[0] = listaboletas[c].Idboleta;
                        registroBoleta[1] = listaboletas[c].Fechaboleta;
                        registroBoleta[2] = listaboletas[c].NumeroDocumento;
                        dgvVenta.Rows.Add(registroBoleta);
                    }
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            
            int idBoleta = Int32.Parse(txt_idventa.Text);
            ControladorBoleta cb = new ControladorBoleta();
            int estado = cb.EliminarBoleta(idBoleta);
            switch (estado)
            {
                case 1:
                    l_mensajes.Text = "Datos del Producto Eliminados";
                    
                    Limpiar();
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
        }

        private void CargarDetalle(Boleta boleta)
        {
            DetalleVenta fDetVenta = DetalleVenta.GetInstance();
            fDetVenta.SetVenta(boleta);
            fDetVenta.ShowDialog();
        }

        private void dgvVenta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvVenta.CurrentRow != null)
            {
                Boleta boleta = new Boleta();

                boleta.Idboleta = Convert.ToInt32(dgvVenta.CurrentRow.Cells["dgvId_venta"].Value.ToString());
                boleta.Fechaboleta = Convert.ToDateTime(dgvVenta.CurrentRow.Cells["fecha"].Value.ToString());
                boleta.NumeroDocumento = dgvVenta.CurrentRow.Cells["nro_doc"].Value.ToString();

                CargarDetalle(boleta);
            }
        }
    }   
}
