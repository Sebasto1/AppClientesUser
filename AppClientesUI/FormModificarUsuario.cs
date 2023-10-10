using AppClientesBussiness;
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM
{

    public partial class FormModificarUsuario : Form
    {
        private Usuario usuario;
        
        public FormModificarUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            

            // Mostrar los detalles del producto en los TextBox

            txtNombreUsuario.Text = usuario.NombreUsuario.ToString();
            txtNombre.Text = usuario.Nombre.ToString();
            txtApellido.Text = usuario.Apellido.ToString();
            txtContraseña.Text = usuario.Apellido.ToString();
            txtMail.Text = usuario.Mail.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Capturar los cambios realizados por el usuario

            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Mail = txtMail.Text;

            try
            {
                // Llamar al método para modificar el producto
                UsuarioBussiness.ModifyUsuario(usuario);

                // Mostrar un mensaje indicando el éxito de la operación
                MessageBox.Show("Usuario modificado correctamente.");

                // Cerrar el formulario después de guardar los cambios
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el usuario: {ex.Message}");
            }
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
