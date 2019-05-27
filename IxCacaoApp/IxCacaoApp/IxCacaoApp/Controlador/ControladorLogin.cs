using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IxCacaoApp.Controlador
{
    class ControladorLogin
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        static string nombreServidor = "DESKTOP-5UDNSII\\MSSQLSERVER02";
        static string nombreBD = "IXcacao";
        static string Username = "AdminCacaoApp";kjhkjh
        static string contrasena = "Cacao2018app";

        string cadenaConexion = "Data Source=" + nombreServidor + ";User ID=" +
            Username + ";Password=" + contrasena + ";Initial Catalog=" + nombreBD;

       


        public String tieneConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return "OkConexion";
            }
            catch (Exception e)
            {
                return "NokConexion";
            }
            finally
            {
                conexion.Close();
            }
        }

        public int iniciarSesion(string nombreUsuario, string contraseña)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("Select * from Usuario where nomUsuario=@nomUsuario and contraseña=@contraseña", conexion);
                    
                    comando.Parameters.AddWithValue("@nomUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    
                    SqlDataAdapter sda = new SqlDataAdapter(comando);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);

                    if (ds.Rows.Count == 1)
                    {

                        if (ds.Rows[0][3].ToString() == "Admin"){
                            estado = 1;
                        }
                        else if(ds.Rows[0][3].ToString() == "Usuario")
                        {
                            estado = 4;
                        }
                    }
                    else
                    {
                        estado = 5;
                    }
                    
                    return estado;
                }
                else
                {
                    return estado = 2;
                }
            }
            
            finally
            {
                conexion.Close();
            }

        }

        public int CambiarContraseña(int id_usuario, string nomUsuario, string contraseña)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_cambiarContraseña", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_usuario", id_usuario);
                    comando.Parameters.AddWithValue("@nomUsuario", nomUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.ExecuteNonQuery();
                    return 1;
                }
                else
                {
                    return estado;
                }
            }
            catch (Exception e)
            {
                return 3;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
