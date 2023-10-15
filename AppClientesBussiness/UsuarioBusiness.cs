﻿using System;
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

        public static void DeleteUsuario(int id)
        {
            UsuarioData.EliminarUsuario(id);
        }
    }
}