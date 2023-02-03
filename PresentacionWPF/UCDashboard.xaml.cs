using LiveCharts.Wpf;
using LiveCharts;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts.Wpf.Charts.Base;
using Negocio;
using System.Reflection;
using System.Windows.Threading;
using Entidades;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCDashboard.xaml
    /// </summary>
    public partial class UCDashboard : UserControl
    {
        private DispatcherTimer t;
        public int TiempoActualizacion { get; set; }

        public Employee Empleado { get; set; }

        public DatosDashboard DatosDashboard { get; set; }

        public UCDashboard(Employee empleado, MainWindow mainWindow)
        {
            InitializeComponent();
            Empleado = empleado;
            ActualizarDatos(empleado);
            TiempoActualizacion = mainWindow.TiempoActualizacion;
           
            // Temporizador
            t = new DispatcherTimer();
            t.Interval = TimeSpan.FromSeconds(TiempoActualizacion);
            t.Tick += (s, e) =>
            {
                ActualizarDatos(empleado);
            };

            t.Start();
        }

        public void ActualizarDatos(Employee empleado)
        {
            using (Gestion g = new Gestion())
            {
                DatosDashboard = g.ActualizarDashboard(empleado);
            }

            // PASTEL
            SeriesCollection serie1 = new SeriesCollection();

            foreach (KeyValuePair<string, int> d in DatosDashboard.SerieProductosPorCategoria)
            {
                serie1.Add(new PieSeries
                {
                    Title = d.Key,
                    Values = new ChartValues<int> { d.Value },
                    DataLabels = true,
                    LabelPoint = new Func<ChartPoint, string>(chartPoint => d.Key)
                });
            }

            pieChart.Series = serie1;

            // COLUMNAS
            SeriesCollection serie2 = new SeriesCollection();

            serie2.Add(new ColumnSeries
            {
                Values = new ChartValues<int>(DatosDashboard.SeriePedidosCliente.Values)
            });

            columnChartEjeX.Labels = new List<string>(DatosDashboard.SeriePedidosCliente.Keys);
            columnChart.Series = serie2;

            this.DataContext = DatosDashboard;
        }
    }
}
