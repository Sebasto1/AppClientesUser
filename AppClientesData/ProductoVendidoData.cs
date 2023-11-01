using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {

        private static string connectionString = @"Server=Sebasto;Database=SistemaGestion;Trusted_Connection=True;Encrypt=False";

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id,IdVenta,Stock, IdProducto FROM ProductoVendido";
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var productoVendido = new ProductoVendido();
                                    {
                                        productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                        productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                        productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                        productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    }


                                    lista.Add(productoVendido);
                                }
                            }
                        }
                    }


                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            ProductoVendido productoVendido = new ProductoVendido();


            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id,IdVenta,Stock, IdProducto FROM ProductoVendido Where Id=@Id";
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = id });


                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                    productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                }
                            }
                        }
                    }

                    conexion.Close();
                }
                return productoVendido;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
