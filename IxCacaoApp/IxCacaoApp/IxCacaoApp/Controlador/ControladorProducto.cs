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
    class ControladorProducto
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

        Producto p = new Producto();
        List<Producto> listaProductos = new List<Producto>();


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

        public int existeProducto(int idProd)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_existeProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@idprod", SqlDbType.Int);
                    comando.Parameters["@idprod"].Value = idProd;
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

        public int AgregarProducto(int idProd, string nomProd , string origen, int porcentaje, string aroma, string inclusion, string chocolatero, int precio, int stock)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_addProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("idProd", idProd);
                    comando.Parameters.AddWithValue("nomProd", nomProd);
                    comando.Parameters.AddWithValue("origen", origen);
                    comando.Parameters.AddWithValue("porcentaje", porcentaje);
                    comando.Parameters.AddWithValue("aroma", aroma);
                    comando.Parameters.AddWithValue("inclusion", inclusion);
                    comando.Parameters.AddWithValue("chocolatero", chocolatero);
                    comando.Parameters.AddWithValue("precio", precio);
                    comando.Parameters.AddWithValue("stock", stock);
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

        public int ActualizarProducto(int idProd, string nomProd, string origen, int porcentaje, string aroma, string inclusion, string chocolatero, int precio, int stock)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_updateProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idProd", idProd);
                    comando.Parameters.AddWithValue("@nomProd", nomProd);
                    comando.Parameters.AddWithValue("origen", origen);
                    comando.Parameters.AddWithValue("porcentaje", porcentaje);
                    comando.Parameters.AddWithValue("aroma", aroma);
                    comando.Parameters.AddWithValue("inclusion", inclusion);
                    comando.Parameters.AddWithValue("chocolatero", chocolatero);
                    comando.Parameters.AddWithValue("precio", precio);
                    comando.Parameters.AddWithValue("stock", stock);
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

        public int EliminarProducto(int idProd)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_eliminar_producto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("idprod", idProd);
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

        public Producto obtenerDatosProducto()
        {
            return p;
        }

        public int ConsultarUnProducto(int idProd)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaUnProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@idprod", SqlDbType.Int);
                    comando.Parameters["@idprod"].Value = idProd;
                    lector = comando.ExecuteReader();
                    lector.Read();
                    string nombre = lector.GetString(1);
                    string origen = lector.GetString(2);
                    int porcentaje = lector.GetInt32(3);
                    string aroma = lector.GetString(4);
                    string inclusion = lector.GetString(5);
                    string chocolatero = lector.GetString(6);
                    int precio = lector.GetInt32(7);
                    int stock = lector.GetInt32(8);
                    p.IdProd = idProd;
                    p.NomProd = nombre; 
                    p.Origen = origen;
                    p.Porcentaje = porcentaje;
                    p.Aroma = aroma;
                    p.Inclusion = inclusion;
                    p.Chocolatero = chocolatero;
                    p.Precio = precio;
                    p.Stock = stock;
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

        public int ConsultaProductos(string origen, int porcentaje, string aroma, string inclusion, string chocolatero)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {

                    int idprod;
                    string nomprod;                   
                    int precio;
                    int stock;
                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaPractica", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("origen", origen);
                    comando.Parameters.AddWithValue("porcentaje", porcentaje);
                    comando.Parameters.AddWithValue("@aroma", aroma);
                    comando.Parameters.AddWithValue("@inclusion", inclusion);
                    comando.Parameters.AddWithValue("@chocolatero", chocolatero);
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {

                        idprod = lector.GetInt32(0);
                        nomprod = lector.GetString(1);
                        origen = lector.GetString(2);
                        porcentaje = lector.GetInt32(3);
                        aroma = lector.GetString(4);
                        inclusion = lector.GetString(5);
                        chocolatero = lector.GetString(6);
                        precio = lector.GetInt32(7);
                        stock = lector.GetInt32(8);
                        Producto p = new Producto();
                        p.IdProd = idprod;
                        p.NomProd = nomprod;
                        p.Origen = origen;
                        p.Porcentaje = porcentaje;
                        p.Aroma = aroma;
                        p.Inclusion = inclusion;
                        p.Chocolatero = chocolatero;
                        p.Precio = precio;
                        p.Stock = stock;
                        listaProductos.Add(p);
                    }
                    return 1;
                }
                else
                {
                    return estado;
                }
            }
            
            finally
            {
                conexion.Close();
            }

        }
        public List<Producto> obtenerDatosDeProductos()
        {
            return listaProductos/ggfg
        }
        uidjkxdfkgjj()
            efdfegfb
    }
}
