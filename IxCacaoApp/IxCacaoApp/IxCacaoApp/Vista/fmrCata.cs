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
    public partial class fmrCata : Form
    {
        public fmrCata()
        {
            InitializeComponent();
            mostrarCata();
            deshabilitar();
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cata_Load(object sender, EventArgs e)
        {
            mostrarCata();
        }
        #region Habilitar y deshabilitar
        private void deshabilitar()
        {
            txt_idcata.Enabled = true;
            txt_fecha.Enabled = false;
            txt_nom.Enabled = false;
            bt_nuevo.Enabled = true;
            bt_consultar.Enabled = true;
            bt_guardar.Enabled = false;
            bt_actualizar.Enabled = false;
            bt_borrar.Enabled = false;
        }
        private void habilitarGuardar()
        {
            txt_idcata.Enabled = false;
            txt_fecha.Enabled = true;
            txt_nom.Enabled = true;
            bt_nuevo.Enabled = false;
            bt_consultar.Enabled = false;
            bt_guardar.Enabled = true;
            bt_actualizar.Enabled = false;
            bt_borrar.Enabled = false;
        }
        private void habilitarActualizar()
        {
            txt_idcata.Enabled = false;
            txt_fecha.Enabled = true;
            txt_nom.Enabled = true;
            bt_nuevo.Enabled = false;
            bt_consultar.Enabled = false;
            bt_guardar.Enabled = false;
            bt_actualizar.Enabled = true;
            bt_borrar.Enabled = true;
        }

        #endregion

        #region borrar datos
        private void Limpiar()
        {
            txt_idcata.Text = string.Empty;
            txt_fecha.Text = string.Empty;
            txt_nom.Text = string.Empty;

        }

        #endregion

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            habilitarGuardar();
            Limpiar();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            
            l_mensajes.Text = string.Empty;
            if (txt_idcata.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar id de Cata";
                txt_idcata.Focus();
            }
            else
            {
                int idcata;
                if (int.TryParse(txt_idcata.Text, out idcata))
                {
                    if (idcata > 0)
                    {
                        ControladorCata cc = new ControladorCata();
                        int res = cc.existeCata(idcata);
                        switch (res)
                        {
                            case 0:
                                l_mensajes.Text = "Datos del Producto NO existen en BD";
                                break;
                            case 1:
                                int estado = cc.ConsultarUnCata(idcata);
                                switch (estado)
                                {
                                    case 1:
                                        Cata ct = new Cata();
                                        ct = cc.obtenerDatosCata();
                                        txt_idcata.Text = ct.IdCata.ToString(); ;
                                        txt_fecha.Text = ct.FechaCata.ToString();
                                        txt_nom.Text = ct.NombreCata;

                                        dgvCata.Rows.Clear();
                                        object[] registroCata = new object[3];
                                        registroCata[0] = ct.IdCata;
                                        registroCata[1] = ct.FechaCata;
                                        registroCata[2] = ct.NombreCata;
                                        dgvCata.Rows.Add(registroCata);
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
                        txt_idcata.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Ingresar id de Producto numerico entero";
                    txt_idcata.Focus();
                }
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (txt_fecha.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Fecha";

            }
            else
            {
                if (txt_nom.Text.Equals(""))
                {
                    l_mensajes.Text = "Ingresar Nombre cata";
                }
                else
                {
                    ControladorCata cc = new ControladorCata();
                    int estado = cc.AgregarCata(txt_fecha.Value, txt_nom.Text);
                    switch (estado)
                    {
                        case 1:
                            l_mensajes.Text = "Datos de Boleta guardada";
                            mostrarCata();
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

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_idcata.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresa un Id de cata";
            }
            else
            {
                int idCata;
                if (int.TryParse(txt_idcata.Text, out idCata))
                {
                    if (idCata > 0)
                    {

                        if (txt_fecha.Text.Equals(""))
                        {
                            l_mensajes.Text = "Ingresar Fecha";

                        }
                        else
                        {
                            if (txt_nom.Text.Equals(""))
                            {
                                l_mensajes.Text = "Ingresar Nombre de cata";
                            }
                            else
                            {
                                ControladorCata cc = new ControladorCata();
                                int estado = cc.ActualizarCata(idCata, txt_fecha.Value, txt_nom.Text);
                                switch (estado)
                                {
                                    case 1:
                                        l_mensajes.Text = "Datos de Cata Actualizados";
                                        mostrarCata();
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

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            deshabilitar();
            mostrarCata();
        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {
            int idCata = Int32.Parse(txt_idcata.Text);
            ControladorCata cc = new ControladorCata();
            int estado = cc.EliminarCata(idCata);
            switch (estado)
            {
                case 1:
                    l_mensajes.Text = "Cata Eliminada";
                    deshabilitar();
                    Limpiar();
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
        }

        private void mostrarCata()
        {
            l_mensajes.Text = string.Empty;
            ControladorCata cc = new ControladorCata();
            int estado = cc.ConsultarTodasCatas();
            switch (estado)
            {
                case 1:
                    dgvCata.Rows.Clear();
                    Cata ct = new Cata();
                    List<Cata> listacata = new List<Cata>();
                    listacata = cc.obtenerDatostodasCata();
                    for (int c = 0; c < listacata.Count; c++)
                    {
                        object[] registroCata = new object[3];
                        registroCata[0] = listacata[c].IdCata;
                        registroCata[1] = listacata[c].FechaCata;
                        registroCata[2] = listacata[c].NombreCata;
                        dgvCata.Rows.Add(registroCata);
                    }
                    break;
                default:
                    l_mensajes.Text = "NO existe Conexión BD. Contacte a ...";
                    break;
            }
        }

        private void CargarDetalleCata(Cata cata)
        {
            fmrDetalleCata fDetCata = fmrDetalleCata.GetInstance();
            fDetCata.SetCata(cata);
            fDetCata.ShowDialog();
        }

        private void dgvCata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCata.CurrentRow != null)
            {
                Cata cata = new Cata();

                cata.IdCata = Convert.ToInt32(dgvCata.CurrentRow.Cells["dgvId_cata"].Value.ToString());
                cata.FechaCata = Convert.ToDateTime(dgvCata.CurrentRow.Cells["fecha"].Value.ToString());
                cata.NombreCata = dgvCata.CurrentRow.Cells["nombre"].Value.ToString();

                CargarDetalleCata(cata);
            }
        }
    }
}
