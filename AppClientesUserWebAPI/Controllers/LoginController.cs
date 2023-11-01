using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBusiness;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet("Login", Name = "Login")]
        public ActionResult Login(string NombreUsuario, string Contrasena)
        {
            var usuario = UsuarioBusiness.Login(NombreUsuario, Contrasena);

            if (usuario is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(usuario);
            }
            
        }
    }
}
