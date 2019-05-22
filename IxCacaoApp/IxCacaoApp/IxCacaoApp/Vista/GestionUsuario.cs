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
    public partial class GestionUsuario : Form
    {
        public GestionUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (cb_tipoUsuario.SelectedIndex > 0)
            {
                if(tb_nombreUsuario.Text.Equals(""))
                {
                    l_mensajes.Text = "Debe ingresar un Nombre de usuario";
                    tb_nombreUsuario.Focus();
                }
                else
                {
                    if (txt_contraseña.Text.Equals(""))
                    {
                        l_mensajes.Text = "Debe ingresar una Contraseña";
                        txt_contraseña.Focus();
                    }
                    else
                    {
                        if (txt_conContraseña.Text.Equals(""))
                        {
                            l_mensajes.Text = "Debe Confirmar la Contraseña";
                            txt_conContraseña.Focus();
                        }
                        else
                        {
                            if(txt_contraseña.Text == txt_conContraseña.Text)
                            {
                                ControladorLogin cl = new ControladorLogin();
                                int estado = cl.CambiarContraseña(cb_tipoUsuario.SelectedIndex, tb_nombreUsuario.Text, txt_contraseña.Text);
                                switch (estado)
                                {
                                    case 1:
                                        l_mensajes.Text = "Cambios Guardados";
                                        Limpiar();
                                        break;
                                    default:
                                        l_mensajes.Text = "No existe Conexion con la base de datos";
                                        break;
                                }
                            }
                            else
                            {
                                l_mensajes.Text = "La Contraseña Ingresada NO Coincide con la Confirmacion de Contraseña";
                            }
                        }
                    }
                }
            }
            else
            {
                l_mensajes.Text = "Debe ingresar un tipo usuario";
            }
        }

        private void cb_tipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoUsuario.SelectedIndex.Equals("Administrativo"))
            {
                cb_tipoUsuario.SelectedIndex = 1;
            }else if(cb_tipoUsuario.SelectedIndex.Equals("Usuario Comun"))
            {
                cb_tipoUsuario.SelectedIndex = 2;
            }
        }
        private void Limpiar()
        {
            cb_tipoUsuario.Text = string.Empty;
            tb_nombreUsuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;
            txt_conContraseña.Text = string.Empty;
            l_mensajes.Text = string.Empty;
            
        }

        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
