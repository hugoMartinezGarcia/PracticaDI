///<author>Hugo Martínez</author>

using Entidades;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private Employee? empleado = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Método para manejar el botón Salir de la barra de menú
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarFormAcceso();
            MemoryStream mS = new MemoryStream();
            mS.Write(empleado.Photo, 78, empleado.Photo.Length - 78);
            pbEmpleado.Image = Image.FromStream(mS);
            lbEmpleado.Text = empleado.FullName();
        }

        private void CargarFormAcceso()
        {
            FormAcceso formAcceso = new FormAcceso();

            DialogResult respuesta = formAcceso.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                empleado = formAcceso.Empleado;
            }
            else
            {
                this.Close();
            }
        }

        // Manejo del evento FormClosing
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Confirma que desea salir?",
                "Salir de la aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;

                if (empleado == null)
                {
                    CargarFormAcceso();
                }
            }
        }

        private void tsbInsertarEmpleado_Click(object sender, EventArgs e)
        {
            FormInsertarEmpleado formInsertarEmpleado = new FormInsertarEmpleado();
            formInsertarEmpleado.MdiParent = this;
            formInsertarEmpleado.Show();
        }
    }
}