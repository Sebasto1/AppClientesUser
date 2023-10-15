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
        // GET: api/Usuarios
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBusiness.ListUsuario().ToArray();
        }

        // DELETE: api/Usuarios
        [HttpDelete(Name = "DeleteUsuario")]
        public IActionResult Delete([FromBody] int id)
        {
            var usuario = UsuarioBusiness.GetUsuario(id);
            if (usuario.Id == 0)
            {
                return NotFound();
            }
            UsuarioBusiness.DeleteUsuario(id);
            return NoContent();
        }

        // PUT: api/Usuarios
        [HttpPut(Name = "PutUsuario")]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                return BadRequest();
            }
            UsuarioBusiness.ModifyUsuario(usuario);
            return NoContent();
        }

        // POST: api/Usuarios
        [HttpPost(Name = "PostUsuario")]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario.Id != 0)
            {
                return BadRequest();
            }
            UsuarioBusiness.CreateUsuario(usuario);
            return CreatedAtRoute("GetUsuario", new { id = usuario.Id }, usuario);
        }

        // GET: api/Usuarios/5
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
