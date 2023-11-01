using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class UsuarioBusiness
    {
        public static Usuario GetNombre(int id)
        {
            return UsuarioData.ObtenerNombre(id);
        }
        public static Usuario GetUsuario(int id)
        {
            return UsuarioData.ObtenerUsuario(id);
        }

        public static void CreateUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModifyUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }

        public static void DeleteUsuario(int id)
        {
            UsuarioData.EliminarUsuario(id);
        }

        public static Usuario Login(string NombreUsuario, string Contrasena)
        {
            {
                var usuario = UsuarioData.ObtenerUsuarioPorNombreUsuario(NombreUsuario).FirstOrDefault();
                if (usuario == null)
                {
                    return null;
                }
                if (Contrasena == usuario.Contraseña)
                {
                    return usuario;
                }
                return null;
            }
        }
    }
}
