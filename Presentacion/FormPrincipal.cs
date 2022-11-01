///<author>Hugo Mart�nez</author>

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

        // M�todo para manejar el bot�n Salir de la barra de men�
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "�Confirma que desea salir?", 
                "Salir de la aplicaci�n",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
    }
}