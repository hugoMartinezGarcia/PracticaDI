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
        private List<Customer> customers;
        private FormPedidos formPedidos;

        public FormBuscarCustomer(FormPedidos formPedidos)
        {
            InitializeComponent();
            customers = new List<Customer>();
            dtCustomers = new DataTable();
            this.formPedidos = formPedidos;
        }

        private void FormBuscarCustomer_Load(object sender, EventArgs e)
        {
            // Se crea un DataTable con las columnas de Employee que se mostrarán
            dtCustomers.Columns.Add("Customer Id", typeof(string));
            dtCustomers.Columns.Add("Company name", typeof(string));
            dtCustomers.Columns.Add("Contact name", typeof(string));

            RellenarDataTable();
        }

        // Método para rellenar el dgv con la lista de empleados
        private void RellenarDataTable()
        {
            // Se vacía el datatable por si tuviera datos
            dtCustomers.Rows.Clear();

            // Se recupera la lista de empleados de la BBDD
            customers = Gestion.ListarCustomer();

            // Se rellena el Datatable con los datos de la lista de Employees
            customers.ForEach(c => dtCustomers.Rows.Add(c.CustomerId, c.CompanyName, c.ContactName));

            // Se crea el DataView y se le asocia el DataTable
            DataView dv = new DataView(dtCustomers);

            // Se muestran los datos en el DataGridView
            dgvCustomers.DataSource = dv;
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

        
    }
}
