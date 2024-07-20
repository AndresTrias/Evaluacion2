using System;
using System.Windows.Forms;

//using Controlador;



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
            //  controladores.Registrar(txtNombre.Text, txtApellido.Text,
            //  txtContrasenia.Text, txtConfirmarContrasenia.Text);
            MessageBox.Show("Usuario Registrado con Exito");
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContrasenia.Text = "";
            txtConfirmarContrasenia.Text = "";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar el usuario {id}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                //  controladores.Eliminar(id);
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

