///<author>Hugo Martínez</author>

using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Método para manejar el botón Salir de la barra de menú
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Confirma que desea salir?", 
                "Salir de la aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
    }
}