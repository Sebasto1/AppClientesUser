using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBusiness;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBusiness.ListUsuario().ToArray();
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public IActionResult Delete([FromBody] int id)
        {
            var usuario = UsuarioBusiness.GetUsuario(id);
            if (usuario.Id == 0)
            {
                return NotFound();
            }
            UsuarioBusiness.DeleteUsuario(id);
            return Ok();
        }

        [HttpPut(Name = "PutUsuario")]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                return BadRequest();
            }
            UsuarioBusiness.ModifyUsuario(usuario);
            return Ok();
        }

        [HttpPost(Name = "PostUsuario")]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario.Id != 0)
            {
                return BadRequest();
            }
            UsuarioBusiness.CreateUsuario(usuario);
            return CreatedAtRoute("GetUsuarios", new { id = usuario.Id }, usuario);
        }

        [HttpGet("{id}", Name = "GetBuscarUsuario")]
        public ActionResult<Usuario> Get(int id)
        {
            var usuario = UsuarioBusiness.GetUsuario(id);
            if (usuario.Id == 0)
            {
                return NotFound();
            }
            return usuario;
        }
    }
}
