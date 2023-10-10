using AppClientesData;
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ListProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static ProductoVendido GetProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static void CreateProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModifyProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }

        public static void DeleteProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido);
        }
    }
}
