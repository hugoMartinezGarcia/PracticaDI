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

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCDashboard.xaml
    /// </summary>
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();

            Dictionary<string, int> seriePedidosCliente;
            Dictionary<string, int> serieProductosCategoria;

            using (Gestion g = new Gestion())
            {
                seriePedidosCliente = new Dictionary<string, int>(g.SeriePedidosCliente());
                serieProductosCategoria = new Dictionary<string, int>(g.SerieProductosPorCategoria());
            }

            // PASTEL
            SeriesCollection serie1 = new SeriesCollection();

            foreach (KeyValuePair<string, int> d in serieProductosCategoria)
            {
                serie1.Add(new PieSeries
                {
                    Title = d.Key,
                    Values = new ChartValues<int> { d.Value }
                });
            }

            pieChart.Series = serie1;

            // COLUMNAS
            SeriesCollection serie2 = new SeriesCollection();

            serie2.Add(new ColumnSeries
            {
                Values = new ChartValues<int>(seriePedidosCliente.Values)
            });
            
            columnChartEjeX.Labels = new List<string>(seriePedidosCliente.Keys);
            columnChart.Series = serie2;
        }
    }
}
