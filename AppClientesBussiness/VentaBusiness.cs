using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public static class VentaBusiness
    {
        public static List<Venta> ListVentas()
        {
            return VentaData.ListarVentas();
        }

        public static Venta GetVenta(int id)
        {
            return VentaData.ObtenerVenta(id);
        }

        public static void CreateVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }

        public static void ModifyVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }

        public static void DeleteVenta(int id)
        {
            VentaData.EliminarVenta(id);
        }
    }
}
