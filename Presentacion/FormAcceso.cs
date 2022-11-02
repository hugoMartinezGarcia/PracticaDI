using Entidades;
using Negocio;


namespace Presentacion
{
    public partial class FormAcceso : Form
    {
        public FormAcceso()
        {
            InitializeComponent();

            List<Employee> employees = Gestion.ListarEmployee();

            cbEmployee.DataSource = employees;
            
            cbEmployee.ValueMember = "EmployeeId";
            cbEmployee.SelectedItem = null;
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = Convert.ToInt32(tbEmployee.Text);

                if (cbEmployee.SelectedValue != null)
                {
                    int selected = Convert.ToInt32(cbEmployee.SelectedValue);

                    if (selected == id)
                    {
                        MessageBox.Show("Acceso correcto");
                    }
                    else
                    {
                        MessageBox.Show("id incorrecto");
                        tbEmployee.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un employee de la lista");
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("introduce un id válido");
                tbEmployee.Clear();
            }
            
        }

        private void cbEmployee_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstName = (e.ListItem as Employee)!.FirstName;
            string lastName = (e.ListItem as Employee)!.LastName;

            e.Value = firstName + " " + lastName;
        }
    }
}
