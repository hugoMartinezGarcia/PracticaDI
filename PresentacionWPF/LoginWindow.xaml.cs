using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MainWindow mainWindow;
        private int intentos;
        Employee? empleado;


        public LoginWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            intentos = 0;
            List<Employee> empleados = Gestion.ListarEmployee();
            listbEmpleados.ItemsSource= empleados;
            empleado = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Acceder();
        }

        private void Acceder()
        {
            if (listbEmpleados.SelectedItem != null)
            {
                using (Gestion g = new Gestion())
                {
                    try
                    {
                        if (g.ComprobarAcceso((Employee)listbEmpleados.SelectedItem, tbIdEmpleado.Text))
                        {
                            empleado = (Employee)listbEmpleados.SelectedItem;
                            this.Close();
                            mainWindow.DefinirEmpleado(empleado);
                            mainWindow.Show();
                        }
                        else
                        {
                            intentos++;

                            if (intentos == Gestion.INTENTOS)
                            {
                                MessageBox.Show("Has agotado todos los intentos. La aplicación se cerrará");
                                this.Close();
                                mainWindow.Close();
                            }

                            else
                            {
                                MessageBox.Show(String.Format("El id no es correcto. Le quedan {0} intentos",
                                    Gestion.INTENTOS - intentos));
                                tbIdEmpleado.Clear();
                            }
                        }
                    }
                    // Captura la excepción que lanza el método ComprobarAcceso(Employee, string)
                    catch (FormatException e)
                    {
                        MessageBox.Show(e.Message);
                        tbIdEmpleado.Clear();
                    }
                }
            }
            else
                MessageBox.Show("Debes seleccionar un empleado de la lista!");
        }

        private void tbIdEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Acceder();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (empleado == null)
                mainWindow.Close();
        }
    }
}
