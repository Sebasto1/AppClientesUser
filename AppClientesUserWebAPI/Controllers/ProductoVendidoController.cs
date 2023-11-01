using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBusiness.ListProductosVendidos().ToArray();
        }


        [HttpGet("{id}", Name = "GetBuscarProductoVendido")]
        public ActionResult<ProductoVendido> Get(int id)
        {
            var productoVendido = ProductoVendidoBusiness.GetProductoVendido(id);
            if (productoVendido.Id == 0)
            {
                return NotFound();
            }
            return productoVendido;
        }
    }

    
}
