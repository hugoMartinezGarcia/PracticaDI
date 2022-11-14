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
    public partial class FormBuscarEmpleado : Form
    {
        private DataTable dtEmployees;
        public FormBuscarEmpleado()
        {
            InitializeComponent();

            List<Employee> employees = new List<Employee>();
            employees = Gestion.ListarEmployee();

            dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Employee Id", typeof(int));
            dtEmployees.Columns.Add("First name", typeof(string));
            dtEmployees.Columns.Add("Last name", typeof(string));

            employees.ForEach(e => dtEmployees.Rows.Add(e.EmployeeId, e.FirstName, e.LastName));

            DataView dv = new DataView(dtEmployees);

            dgvEmployees.DataSource = dv;

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtEmployees);

            // Filtro para buscar en id, first name y last name
            // se convierte el valor del id a String
            dv.RowFilter = String.Format(
                "Convert([Employee Id], System.String) LIKE '%{0}%' " +
                "OR [First name] LIKE '%{0}%' " +
                "OR [Last name] LIKE '%{0}%'", 
                tbBuscar.Text);

            dgvEmployees.DataSource = dv;
        }
    }
}
