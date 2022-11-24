using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormBuscarCustomer : Form
    {
        private DataTable dtCustomers;
        private FormPedidos formPedidos;

        public FormBuscarCustomer(FormPedidos formPedidos)
        {
            InitializeComponent();
            dtCustomers = new DataTable();
            this.formPedidos = formPedidos;
        }

        private void FormBuscarCustomer_Load(object sender, EventArgs e)
        {
            using (Gestion g = new Gestion()) 
            {
                dtCustomers = g.DataTableCustomers();
            }

            dgvCustomers.DataSource = dtCustomers;
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Nuevo DataView con los datos del DataTable dtEmployees
            DataView dv = new DataView(dtCustomers);

            // Filtro para buscar en id, first name y last name
            // Se convierte el valor del id a String
            dv.RowFilter = String.Format(
                "[Customer Id] LIKE '%{0}%' " +
                "OR [Company name] LIKE '%{0}%' " +
                "OR [Contact name] LIKE '%{0}%'",
                tbBuscar.Text);

            // Se pasa el DataView filtrado al DataGridView
            dgvCustomers.DataSource = dv;
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string customerId = (string)dgvCustomers.CurrentRow.Cells["Customer Id"].Value;
                Customer customer = new Customer();

                using (Gestion g = new Gestion())
                {
                    customer = g.BuscarCustomer(customerId);
                }

                // Se envía el customer al Form Pedidos
                formPedidos.DefinirCustomer(customer);
                this.Close();
            }
            catch
            {
                // Ignorar la excepción
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
