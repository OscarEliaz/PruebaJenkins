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
    public class ControladorDetalleCata
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
        DetalleCata dc = new DetalleCata();
        Producto p = new Producto();
        List<DetalleCata> listaLosProductos = new List<DetalleCata>();

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
        //Producto producto, Boleta boleta, int cantidad, int precioUnitario
        public int AgregarDetalleCata(int cata, int producto)
        {
            int estado = 2;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_addDetalleCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_cata", cata);
                    comando.Parameters.AddWithValue("@id_prod", producto);
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

        public int EliminarDetalleCata(int id_prod)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_eliminar_DetalleCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_prod", id_prod);
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

        public int ConsultarTodosLosProductos(int idcata)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {

                    DateTime fechaCata;
                    string nombreCata;
                    int idDetalleCata;
                    int idProd;
                    string nomProd;
                    string origen;
                    int porcentaje;
                    string aroma;
                    string inclusion;
                    string chocolatero;
                    listaLosProductos.Clear();

                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaDetalleCata", conexion);
                    comando.Parameters.AddWithValue("@id_cata", idcata);
                    comando.CommandType = CommandType.StoredProcedure;
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        idcata = lector.GetInt32(0);
                        fechaCata = lector.GetDateTime(1);
                        nombreCata = lector.GetString(2);
                        idDetalleCata = lector.GetInt32(3);
                        idProd = lector.GetInt32(4);
                        nomProd = lector.GetString(5);
                        origen = lector.GetString(6);
                        porcentaje = lector.GetInt32(7);
                        aroma = lector.GetString(8);
                        inclusion = lector.GetString(9);
                        chocolatero = lector.GetString(10);
                        DetalleCata dc = new DetalleCata();
                        dc.Cata.IdCata = idcata;
                        dc.Cata.FechaCata = fechaCata;
                        dc.Cata.NombreCata = nombreCata;
                        dc.IdDetalleCata = idDetalleCata;
                        dc.Producto.IdProd = idProd;
                        dc.Producto.NomProd = nomProd;
                        dc.Producto.Origen = origen;
                        dc.Producto.Porcentaje = porcentaje;
                        dc.Producto.Aroma = aroma;
                        dc.Producto.Inclusion = inclusion;
                        dc.Producto.Chocolatero = chocolatero;
                        listaLosProductos.Add(dc);
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

        public List<DetalleCata> obtenerDatostodasProducto()
        {
            return listaLosProductos;
        }

        public int existeDetalleCata(int idProd)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_existeDetalleCata", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id_prod", SqlDbType.Int);
                    comando.Parameters["@id_prod"].Value = idProd;
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
    }
}
