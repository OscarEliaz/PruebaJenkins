using IxCacaoApp.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxCacaoApp.Controlador
{
    public class ControladorCata
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        static string nombreServidor = "DESKTOP-5UDNSII\\MSSQLSERVER02";
        static string nombreBD = "IXcacao";
        static string Username = "AdminCacaoApp";
        static string contrasena = "Cacao2018app";

        string cadenaConexion = "Data Source=" + nombreServidor + ";User ID=" +
            Username + ";Password=" + contrasena + ";Initial Catalog=" + nombreBD;


        Cata ct = new Cata();
        List<Cata> listacata = new List<Cata>();

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
        
        public int AgregarCata(DateTime fechacata, string nombre)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_addCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@fecha_cata", fechacata);
                    comando.Parameters.AddWithValue("@nombre", nombre);
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
        public int ActualizarCata(int idcata, DateTime fechacata, string nombre)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_updateCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_cata", idcata);
                    comando.Parameters.AddWithValue("@fecha_cata", fechacata);
                    comando.Parameters.AddWithValue("@nombre", nombre);
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
        public int EliminarCata(int idcata)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_eliminar_Cata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_cata", idcata);
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

        public int ConsultarTodasCatas()
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    int idcata;
                    DateTime fechacata;
                    string nombre;
                    listacata.Clear();

                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        idcata = lector.GetInt32(0);
                        fechacata = lector.GetDateTime(1);
                        nombre = lector.GetString(2);
                        Cata ct = new Cata();
                        ct.IdCata = idcata;
                        ct.FechaCata = fechacata;
                        ct.NombreCata = nombre;

                        listacata.Add(ct);
                    }
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
        public List<Cata> obtenerDatostodasCata()
        {
            return listacata;
        }

        public int existeCata(int idcata)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_existeCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id_cata", SqlDbType.Int);
                    comando.Parameters["@id_cata"].Value = idcata;
                    lector = comando.ExecuteReader();
                    lector.Read();
                    estado = lector.GetInt32(0);
                    return estado;
                }
                else
                {
                    return estado;
                }
            }
            catch (Exception e)
            {
                return estado;
            }
            finally
            {
                conexion.Close();
            }

        }
        public int ConsultarUnCata(int idcata)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaunCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id_cata", SqlDbType.Int);
                    comando.Parameters["@id_cata"].Value = idcata;
                    lector = comando.ExecuteReader();
                    lector.Read();
                    DateTime fechaCata = lector.GetDateTime(1);
                    string nombreCata = lector.GetString(2);

                    ct.IdCata = idcata;
                    ct.FechaCata = fechaCata;
                    ct.NombreCata = nombreCata;

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
        public Cata obtenerDatosCata()
        {
            return ct;
        }
    }
}
