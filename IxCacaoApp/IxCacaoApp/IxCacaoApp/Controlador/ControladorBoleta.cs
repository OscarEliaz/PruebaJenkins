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
    public class ControladorBoleta
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


        Boleta b = new Boleta();
        List<Boleta> listaboletas = new List<Boleta>();

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
        //int idboleta, DateTime fechaboleta, string numeroDocumento
        public int AgregarBoleta( DateTime fechaboleta, string numeroDocumento)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_addBoleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@fecha_boleta", fechaboleta);
                    comando.Parameters.AddWithValue("@nro_doc", numeroDocumento);
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

        public int ActualizarBoleta(int idboleta, DateTime fechaboleta, string numeroDocumento)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_updateBoleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_boleta", idboleta);
                    comando.Parameters.AddWithValue("@fecha_boleta", fechaboleta);
                    comando.Parameters.AddWithValue("@nro_doc", numeroDocumento);
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

        public int EliminarBoleta(int idboleta)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_eliminar_Boleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_boleta", idboleta);
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
      
        public int ConsultarTodasBoletas()
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    int idboleta;
                    DateTime fechaboleta;
                    string numeroDocumento;
                    listaboletas.Clear();

                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaBoleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        idboleta = lector.GetInt32(0);
                        fechaboleta = lector.GetDateTime(1);
                        numeroDocumento = lector.GetString(2);
                        Boleta b = new Boleta();
                        b.Idboleta = idboleta;
                        b.Fechaboleta = fechaboleta;
                        b.NumeroDocumento = numeroDocumento;
                        
                        listaboletas.Add(b);
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

        public List<Boleta> obtenerDatostodasBoletas()
        {
            return listaboletas;
        }

        public int existBoleta(int idboleta)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_existeBoleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id_boleta", SqlDbType.Int);
                    comando.Parameters["@id_boleta"].Value = idboleta;
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

        public int ConsultarUnBoleta(int idboleta)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaunBoleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id_boleta", SqlDbType.Int);
                    comando.Parameters["@id_boleta"].Value = idboleta;
                    lector = comando.ExecuteReader();
                    lector.Read();
                    DateTime fechaboleta = lector.GetDateTime(1);
                    string numeroDocumento = lector.GetString(2);
                    
                    b.Idboleta = idboleta;
                    b.Fechaboleta = fechaboleta;
                    b.NumeroDocumento = numeroDocumento;
                    
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

        public Boleta obtenerDatosBoleta()
        {
            return b;
        }
    }
}
