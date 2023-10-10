using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppClientesData;
using AppClientesEntities;

namespace AppClientesBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> ListProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static Producto GetProductos(int id)
        {
            return ProductoData.ObtenerProducto(id);
        }

        public static void CreateProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModifyProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }


        public static void DeleteProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }
    }
}
