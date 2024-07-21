using System;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                controladores.Registrar(txtNombre.Text, txtApellido.Text, txtContrasenia.Text, txtConfirmarContrasenia.Text);
                MessageBox.Show("Usuario Registrado con Éxito");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtContrasenia.Text = "";
                txtConfirmarContrasenia.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (tablaDeDatos.SelectedRows.Count > 0)
            {
                string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro que quiere eliminar el usuario {id}?",
                    "¿Está seguro?",
                    MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    controladores.Eliminar(id);
                    MessageBox.Show("Usuario eliminado con éxito");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
