using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FormEstadisticas : Form
    {
        private int selectedPage;
        public FormEstadisticas(int selectedPage)
        {
            InitializeComponent();
            this.selectedPage = selectedPage;
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            this.tcEstadisticas.SelectedIndex = selectedPage;
            Dictionary<string, int> seriePedidosCliente;
            Dictionary<string, int> serieProductosCategoria;

            using (Gestion g = new Gestion())
            {
                seriePedidosCliente = new Dictionary<string, int>(g.SeriePedidosCliente());
                serieProductosCategoria = new Dictionary<string, int>(g.SerieProductosPorCategoria());

            }  


            foreach (KeyValuePair<string, int> d in seriePedidosCliente)
            {
                // Se añaden los valores al gráfico
                int indice = chart1.Series["Nº pedidos"].Points.AddXY(d.Key, d.Value);
                // Se coloca un tool tip a cada punto para mostrar los datos más grandes
                chart1.Series["Nº pedidos"].Points[indice].ToolTip = String.Format("{0} ({1})", d.Key, d.Value);
            }

            foreach (KeyValuePair<string, int> d in serieProductosCategoria)
            {
                // Se añaden los valores al gráfico
                int indice = chart2.Series["Categorias"].Points.AddXY(d.Key, d.Value);
                // Se coloca un tool tip a cada punto para mostrar los datos más detallados
                chart2.Series["Categorias"].Points[indice].ToolTip = String.Format("{0} ({1}%)", d.Key, d.Value);
            }
        }
    }
}
