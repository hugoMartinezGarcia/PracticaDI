///<author>Hugo Mart�nez</author>

using Entidades;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form, IForm
    {
        private Employee? empleado;

        public FormPrincipal()
        {
            InitializeComponent();
            empleado = null;
        }

        // M�todo para manejar el bot�n Salir de la barra de men�
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarFormAcceso();
            
            
        }

        private void CargarFormAcceso()
        {
            FormAcceso formAcceso = new FormAcceso(this);

            DialogResult respuesta = formAcceso.ShowDialog();
            
            if (respuesta == DialogResult.OK)
            {
                pbEmpleado.Image = ByteArrayToImage(empleado!.Photo);
                lbEmpleado.Text = empleado!.FullName();
            }
            else
            {
                this.Close();
            }
        }

        public Image? ByteArrayToImage(byte[]? byteArray)
        {
            ImageConverter converter = new ImageConverter();
            Image? imagen = (Image?)converter.ConvertFrom(byteArray);

            return imagen;
        }

        // Manejo del evento FormClosing
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "�Confirma que desea salir?",
                "Salir de la aplicaci�n",
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

        // M�todo implementado por heredar de la interfaz IForm.
        // A trav�s de este m�todo se recibe el empleado que accede a la aplicaci�n desde el Form Acceso.
        public void DefinirEmpleado(Employee empleado)
        {
            this.empleado = empleado;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarEmpleado formBuscarEmpleado = new FormBuscarEmpleado();
            formBuscarEmpleado.MdiParent = this;
            formBuscarEmpleado.Show();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbInsertarEmpleado_Click(sender, e);
        }
    }
}