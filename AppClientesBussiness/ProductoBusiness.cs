using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class ProductoBusiness
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


        public static void DeleteProducto(int id)
        {
            ProductoData.EliminarProducto(id);
        }
    }
}
