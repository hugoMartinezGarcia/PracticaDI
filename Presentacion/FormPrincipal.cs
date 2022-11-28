///<author>Hugo Martínez</author>

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

        // Método para manejar el botón Salir de la barra de menú
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
                pbEmpleado.Image = empleado!.Photo != null ?  ByteArrayToImage(empleado.Photo): null;
                lbEmpleado.Text = empleado!.FullName();
            }
            else
            {
                this.Close();
            }
        }

        // Método para convertir un array de bytes a imagen
        public Image? ByteArrayToImage(byte[] byteArray)
        {
            ImageConverter converter = new ImageConverter();
            Image? imagen = (Image?)converter.ConvertFrom(byteArray);

            return imagen;
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
            FormInsertarEmpleado formInsertarEmpleado = new FormInsertarEmpleado(false);
            formInsertarEmpleado.MdiParent = this;
            formInsertarEmpleado.Show();
        }

        // Método implementado por heredar de la interfaz IForm.
        // A través de este método se recibe el empleado que accede a la aplicación desde el Form Acceso.
        public void DefinirEmpleado(Employee empleado)
        {
            this.empleado = empleado;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarEmpleado formBuscarEmpleado = new FormBuscarEmpleado(true);
            formBuscarEmpleado.MdiParent = this;
            formBuscarEmpleado.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarEmpleado formBuscarEmpleado = new FormBuscarEmpleado(false);
            formBuscarEmpleado.MdiParent = this;
            formBuscarEmpleado.Show();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbInsertarEmpleado_Click(sender, e);
        }

        private void modificarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void tsmAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercaDe= new FormAcercaDe();
            formAcercaDe.Show();
        }

        private void totalPedidosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas= new FormEstadisticas(0);
            formEstadisticas.MdiParent = this;
            formEstadisticas.Show();
        }

        private void productosPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new FormEstadisticas(1);
            formEstadisticas.MdiParent = this;
            formEstadisticas.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbNuevoPedido_Click(sender, e);
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBuscarOrder formBuscarOrder = new FormBuscarOrder(false);
            formBuscarOrder.MdiParent = this;
            formBuscarOrder.Show();
        }

        

        private void tsbNuevoPedido_Click(object sender, EventArgs e)
        {
            FormPedidos formNuevoPedido = new FormPedidos(false);
            formNuevoPedido.DefinirEmployee(empleado!);
            formNuevoPedido.MdiParent = this;
            formNuevoPedido.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbImprimirFactura_Click(sender, e);
        }

        private void tsbImprimirFactura_Click(object sender, EventArgs e)
        {
            FormBuscarOrder formBuscarOrder = new FormBuscarOrder(true);
            formBuscarOrder.MdiParent = this;
            formBuscarOrder.Show();
        }
    }
}