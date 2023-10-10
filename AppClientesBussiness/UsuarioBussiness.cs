using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppClientesData;
using AppClientesEntities;

namespace AppClientesBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ListUsuario()
        {
            return UsuarioData.ListarUsuarios();
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

        public static void DeleteUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }
    }
}
