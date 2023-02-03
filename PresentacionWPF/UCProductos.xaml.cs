using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCProductos.xaml
    /// </summary>
    public partial class UCProductos : UserControl
    {
        private MainWindow mainWindow; 
        private Employee usuario;
        private ObservableCollection<Category> categorias;
        private CollectionViewSource MiVista;
        public UCProductos(Employee usuario, MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.usuario = usuario;
            MiVista = (CollectionViewSource)FindResource("Categorias");
            this.DataContext = MiVista;
            using (Gestion g = new Gestion())
            {
                categorias = new ObservableCollection<Category>(g.ListarCategoriasConDatos());
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MiVista.Source = categorias;
        }

        private void tbBuscarCategoria_TextChanged(object sender, TextChangedEventArgs e)
        {
            MiVista.Filter += Filtrar;
        }

        private void Filtrar(object sender, FilterEventArgs e)
        {
            Category categoria = (Category)e.Item;

            if (categoria != null)
            {
                string textoABuscar = tbBuscarCategoria.Text.ToLower().Trim();
                string categoryName = categoria.CategoryName.ToLower();
                
                if (categoryName.Contains(textoABuscar))
                {
                    e.Accepted = true;
                }
                else
                    e.Accepted = false;
            }
        }

        private void btRetroceder_Click(object sender, RoutedEventArgs e)
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCDashboard(usuario, mainWindow));
        }

        
    }
}
