using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        [HttpDelete(Name = "DeleteProducto")]
        public IActionResult Delete([FromBody] int id)
        {
            var producto = ProductoBusiness.GetProductos(id);
            if (producto.Id == 0)
            {
                return NotFound();
            }
            ProductoBusiness.DeleteProducto(id);
            return Ok();
        }

        [HttpPut(Name = "PutProducto")]
        public IActionResult Put([FromBody] Producto producto)
        {
            if (producto.Id == 0)
            {
                return BadRequest();
            }
            ProductoBusiness.ModifyProducto(producto);
            return Ok();
        }

        [HttpPost(Name = "PostProducto")]
        public IActionResult Post([FromBody] Producto producto)
        {
            if (producto.Id != 0)
            {
                return BadRequest();
            }
            ProductoBusiness.CreateProducto(producto);
            return CreatedAtRoute("GetProducto", new { id = producto.Id }, producto);
        }

        [HttpGet("{id}", Name = "GetBuscarProducto")]
        public ActionResult<Producto> Get(int id)
        {
            var producto = ProductoBusiness.GetProductos(id);
            if (producto.Id == 0)
            {
                return NotFound();
            }
            return Ok(producto);
        }
    }
}

