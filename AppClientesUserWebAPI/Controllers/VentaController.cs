using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        // GET: api/Ventas
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return VentaBusiness.ListVentas().ToArray();
        }

        // DELETE: api/Ventas
        [HttpDelete(Name = "DeleteVenta")]
        public IActionResult Delete([FromBody] int id)
        {
            var venta = VentaBusiness.GetVenta(id);
            if (venta.Id == 0)
            {
                return NotFound();
            }
            VentaBusiness.DeleteVenta(id);
            return NoContent();
        }

        // PUT: api/Ventas
        [HttpPut(Name = "PutVenta")]
        public IActionResult Put([FromBody] Venta venta)
        {
            if (venta.Id == 0)
            {
                return BadRequest();
            }
            VentaBusiness.ModifyVenta(venta);
            return NoContent();
        }

        // POST: api/Ventas
        [HttpPost(Name = "PostVenta")]
        public IActionResult Post([FromBody] Venta venta)
        {
            if (venta.Id != 0)
            {
                return BadRequest();
            }
            VentaBusiness.CreateVenta(venta);
            return CreatedAtRoute("GetVenta", new { id = venta.Id }, venta);
        }

        // GET: api/Ventas/5
        [HttpGet("{id}", Name = "GetBuscarVenta")]
        public ActionResult<Venta> Get(int id)
        {
            var venta = VentaBusiness.GetVenta(id);
            if (venta.Id == 0)
            {
                return NotFound();
            }
            return venta;
        }
    }
}
