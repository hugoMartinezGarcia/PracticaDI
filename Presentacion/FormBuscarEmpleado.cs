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
        private List<Employee> employees;
        public FormBuscarEmpleado()
        {
            InitializeComponent();
            employees = new List<Employee>();
            dtEmployees = new DataTable();
        }

        private void FormBuscarEmpleado_Load(object sender, EventArgs e)
        {
            // Se recupera la lista de empleados de la BBDD
            employees = Gestion.ListarEmployee();

            // Se crea un DataTable con las columnas de Employee que se mostrarán
            dtEmployees.Columns.Add("Employee Id", typeof(int));
            dtEmployees.Columns.Add("First name", typeof(string));
            dtEmployees.Columns.Add("Last name", typeof(string));

            // Se rellena el Datatable con los datos de la lista de Employees
            employees.ForEach(e => dtEmployees.Rows.Add(e.EmployeeId, e.FirstName, e.LastName));

            // Se crea el DataView y se le asocia el DataTable
            DataView dv = new DataView(dtEmployees);

            // Se muestran los datos en el DataGridView
            dgvEmployees.DataSource = dv;
        }

        // Método que se lanza cada vez que se modifica el textbox tbBuscar
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Nuevo DataView con los datos del DataTable dtEmployees
            DataView dv = new DataView(dtEmployees);

            // Filtro para buscar en id, first name y last name
            // Se convierte el valor del id a String
            dv.RowFilter = String.Format(
                "Convert([Employee Id], System.String) LIKE '%{0}%' " +
                "OR [First name] LIKE '%{0}%' " +
                "OR [Last name] LIKE '%{0}%'", 
                tbBuscar.Text);

            // Se pasa el DataView filtrado al DataGridView
            dgvEmployees.DataSource = dv;
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvEmployees.CurrentRow.Cells["Employee Id"].Value;
            Employee emp = new Employee();

            using (Gestion g = new Gestion())
            {
                emp = g.BuscarEmployee(id);
            }

            FormInsertarEmpleado formActualizarEmpleado = new FormInsertarEmpleado(emp);
            formActualizarEmpleado.MdiParent = this.MdiParent;
            this.Close();
            formActualizarEmpleado.Show();
        }
    }
}
