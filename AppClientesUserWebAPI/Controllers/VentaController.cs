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
        
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Get()
        {
            return VentaBusiness.ListVentas().ToArray();
        }

        [HttpPut(Name = "PutVenta")]
        public IActionResult Put([FromBody] Venta venta)
        {
            if (venta.Id == 0)
            {
                return BadRequest();
            }
            VentaBusiness.ModifyVenta(venta);
            return Ok();
        }

        [HttpDelete(Name = "DeleteVenta")]
        public IActionResult Delete([FromBody] int id)
        {
            var venta = VentaBusiness.GetVenta(id);
            if (venta.Id == 0)
            {
                return NotFound();
            }
            VentaBusiness.DeleteVenta(id);
            return Ok();
        }

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
