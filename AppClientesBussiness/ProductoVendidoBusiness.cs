using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public static class ProductoVendidoBusiness
    {
        public static List<ProductoVendido> ListProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static ProductoVendido GetProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }

    }
}
