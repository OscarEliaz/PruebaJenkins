using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using IxCacaoApp.Controlador;
using IxCacaoApp.Modelo;

namespace IxCacaoApp.Vista
{
    public partial class Inicio : Form
    {
        ControladorLogin cl = new ControladorLogin();

        public Inicio()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text.Equals(""))
            {
                l_mensajes.Text = "Ingresar Usuario";
                tb_usuario.Focus();
            }else
            {
                if (tb_contraseña.Text.Equals(""))
                {
                    l_mensajes.Text = "Ingresar Contraseña";
                    tb_usuario.Focus();
                }
                else
                {

                    

                    int estado = cl.iniciarSesion(tb_usuario.Text, tb_contraseña.Text);
                    
                    switch (estado)
                    {
                        case 1:
                            this.Hide();
                            MenuAdministrador ma = new MenuAdministrador();
                            ma.Show();
                            break;
                        case 4:
                            this.Hide();
                            MenuUsuario mu = new MenuUsuario();
                            mu.Show();
                            break;
                        case 5:
                            l_mensajes.Text = "Usuario o Contraseña incorrecta";
                            break;
                        default:
                            l_mensajes.Text = "No existe Conexion con la base de datos";
                            break;
                    }
                }
            }
           
        }
    

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_contraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
