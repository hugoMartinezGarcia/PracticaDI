using Entidades;
using Negocio;


namespace Presentacion
{
    public partial class FormAcceso : Form
    {
        internal Employee? empleado;
        // Se crea una variable de tipo Interfaz IForm para pasar el empleado al Form Principal
        private IForm iFormPrincipal;

        public FormAcceso(IForm iFormPrincipal)
        {
            InitializeComponent();
            empleado = null;
            this.iFormPrincipal = iFormPrincipal;

            List<Employee> employees = Gestion.ListarEmployee();
        
            lbEmployees.DataSource = employees;
            lbEmployees.ValueMember = "EmployeeId";
            lbEmployees.SelectedItem = null;
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbIdEmployee.Text);

                if (lbEmployees.SelectedValue != null)
                {
                    int selected = Convert.ToInt32(lbEmployees.SelectedValue);

                    if (selected == id)
                    {
                        using (Gestion g = new Gestion())
                        {
                            empleado = g.BuscarEmployee(selected);
                        }

                        // Se pasa el empleado al Form Principal utilizando la interfaz
                        iFormPrincipal.DefinirEmpleado(empleado);
                        // Se indica que el acceso ha sido correcto
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("id incorrecto");
                        tbIdEmployee.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un employee de la lista");
                    tbIdEmployee.Clear();
                } 
            }
            catch (FormatException)
            {
                MessageBox.Show("introduce un id válido");
                tbIdEmployee.Clear();
            }    
        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstName = (e.ListItem as Employee)!.FirstName;
            string lastName = (e.ListItem as Employee)!.LastName;

            e.Value = firstName + " " + lastName;
        }
    }
}
