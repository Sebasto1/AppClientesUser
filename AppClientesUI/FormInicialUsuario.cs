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
    public partial class FormInicialUsuario : Form
    {
        

        public FormInicialUsuario()
        {
            InitializeComponent();
        }
        private void MostrarListaUsuarios()
        {
            List<Usuario> usuarios = UsuarioBussiness.ListUsuario();

            // Asigna la lista de productos al DataGridView
            dataGridView1.DataSource = usuarios;

            // Opcional: Configura las columnas si es necesario
            dataGridView1.Columns["Id"].Visible = true; // Puedes ocultar columnas si es necesario
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta automáticamente el tamaño de las columnas
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtén el producto seleccionado
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Usuario usuarioSeleccionado = (Usuario)selectedRow.DataBoundItem;

                // Abre el formulario para modificar el producto
                FormModificarUsuario formModificarUsuario = new FormModificarUsuario(usuarioSeleccionado);
                formModificarUsuario.ShowDialog();

                // Actualiza la lista de productos después de modificar
                MostrarListaUsuarios();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario();
            formCrearUsuario.Show();

        }

        private void btnRecargarBD_Click(object sender, EventArgs e)
        {
            MostrarListaUsuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarUsuario formBuscarUsuario = new FormBuscarUsuario();
            formBuscarUsuario.Show();

        }

        private void FormInicialUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
