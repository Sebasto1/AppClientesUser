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

        // DELETE: api/ProductosVendidos
        [HttpDelete(Name = "DeleteProductoVendido")]
        public IActionResult Delete([FromBody] int id)
        {
            var productoVendido = ProductoVendidoBusiness.GetProductoVendido(id);
            if (productoVendido.Id == 0)
            {
                return NotFound();
            }
            ProductoVendidoBusiness.DeleteProductoVendido(id);
            return NoContent();
        }

        // PUT: api/ProductosVendidos
        [HttpPut(Name = "PutProductoVendido")]
        public IActionResult Put([FromBody] ProductoVendido productoVendido)
        {
            if (productoVendido.Id == 0)
            {
                return BadRequest();
            }
            ProductoVendidoBusiness.ModifyProductoVendido(productoVendido);
            return NoContent();
        }

        // POST: api/ProductosVendidos
        [HttpPost(Name = "PostProductoVendido")]
        public IActionResult Post([FromBody] ProductoVendido productoVendido)
        {
            if (productoVendido.Id != 0)
            {
                return BadRequest();
            }
            ProductoVendidoBusiness.CreateProductoVendido(productoVendido);
            return CreatedAtRoute("GetProductoVendido", new { id = productoVendido.Id }, productoVendido);
        }

        // GET: api/ProductosVendidos/5
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
