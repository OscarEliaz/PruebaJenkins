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
    public class ControladorDetalleBoleta
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
        DetalleBoleta db = new DetalleBoleta();
        Producto p = new Producto();
        List<DetalleBoleta> listaLosProductos = new List<DetalleBoleta>();

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
        public int AgregarDetalleBoleta(int boleta, int producto, int cantidad, int precioUnitario)
        {
            int estado = 2;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_addDetalleBoleta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_boleta", boleta);
                    comando.Parameters.AddWithValue("@id_prod", producto);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@precio_unit", precioUnitario);
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
    
        public int EliminarDetalleBoleta(int id_prod)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_eliminar_DetalleBoleta", conexion);
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

        public int ConsultarTodosLosProductos(int idboleta)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    
                    DateTime fechaboleta;
                    string numeroDocumento;
                    int idDetBta;
                    int idProd;
                    string nomProd;
                    int cantidad;
                    int precioUnitario;
                    listaLosProductos.Clear();

                    conexion.Open();

                    comando = new SqlCommand("sp_ConsultaDetalleProducto", conexion);
                    comando.Parameters.AddWithValue("@id_boleta", idboleta);
                    comando.CommandType = CommandType.StoredProcedure;
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        idboleta = lector.GetInt32(0);
                        fechaboleta = lector.GetDateTime(1);
                        numeroDocumento = lector.GetString(2);
                        idDetBta = lector.GetInt32(3);
                        idProd = lector.GetInt32(4);
                        nomProd = lector.GetString(5);
                        cantidad = lector.GetInt32(6);
                        precioUnitario = lector.GetInt32(7);
                        DetalleBoleta db = new DetalleBoleta();
                        db.Boleta.Idboleta = idboleta;
                        db.Boleta.Fechaboleta = fechaboleta;
                        db.Boleta.NumeroDocumento = numeroDocumento;
                        db.IdDetBta = idDetBta;
                        db.Producto.IdProd = idProd;
                        db.Producto.NomProd = nomProd;
                        db.Cantidad = cantidad;
                        db.PrecioUnitario = precioUnitario;
                        listaLosProductos.Add(db);
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

        public List<DetalleBoleta> obtenerDatostodasProducto()
        {
            return listaLosProductos;
        }

        public int reducirStock(int id_prod, int cantidad)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_EliminaStock", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_prod", id_prod);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
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

        public int existeDetalleProducto(int idProd)
        {
            int estado = 2;
            try
            {

                conexion = new SqlConnection(cadenaConexion);
                if (tieneConexion().Equals("OkConexion"))
                {
                    conexion.Open();

                    comando = new SqlCommand("sp_existeDetalleProducto", conexion);
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
