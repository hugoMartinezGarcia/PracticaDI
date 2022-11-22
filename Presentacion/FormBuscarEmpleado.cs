using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private bool modoActualizar;

        public FormBuscarEmpleado(bool modoActualizar)
        {
            InitializeComponent();
            employees = new List<Employee>();
            dtEmployees = new DataTable();
            this.modoActualizar = modoActualizar;
        }

        private void FormBuscarEmpleado_Load(object sender, EventArgs e)
        {
            // Se crea un DataTable con las columnas de Employee que se mostrarán
            dtEmployees.Columns.Add("Employee Id", typeof(int));
            dtEmployees.Columns.Add("First name", typeof(string));
            dtEmployees.Columns.Add("Last name", typeof(string));

            RellenarDataTable();
           
            if (!modoActualizar)
                lbDataGridView.Text = "* Haga doble click sobre el employee para eliminarlo";
        }

        // Método para rellenar el dgv con la lista de empleados
        private void RellenarDataTable()
        {
            // Se vacía el datatable por si tuviera datos
            dtEmployees.Rows.Clear();

            // Se recupera la lista de empleados de la BBDD
            employees = Gestion.ListarEmployee();

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
            try
            {
                int id = (int)dgvEmployees.CurrentRow.Cells["Employee Id"].Value;
                Employee emp = new Employee();

                using (Gestion g = new Gestion())
                {
                    emp = g.BuscarEmployee(id);
                }

                if (modoActualizar)
                {
                    FormInsertarEmpleado formActualizarEmpleado = new FormInsertarEmpleado(true);
                    formActualizarEmpleado.DefinirEmpleado(emp);
                    formActualizarEmpleado.MdiParent = this.MdiParent;
                    this.Close();
                    formActualizarEmpleado.Show();
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show(
                    String.Format("¿Confirma que desea eliminar el empleado {0}- {1} {2}?",
                        emp.EmployeeId, emp.FirstName, emp.LastName),
                    "Eliminar empleado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                    if (respuesta == DialogResult.Yes)
                    {
                        try
                        {
                            using (Gestion g = new Gestion())
                            {
                                g.BorrarEmployee(emp);
                            }

                            MessageBox.Show(String.Format("El empleado {0}- {1} {2} se ha eliminado correctamente",
                                emp.EmployeeId, emp.FirstName, emp.LastName));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No se ha podido eliminar el empleado");
                        }

                        RellenarDataTable();
                    }
                } 
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
