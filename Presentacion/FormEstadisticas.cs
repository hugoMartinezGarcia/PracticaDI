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
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            using (Gestion g = new Gestion())
            {
                Dictionary<string, int> dic = new Dictionary<string, int>(g.SeriePedidosCliente());

                Debug.WriteLine("Dictionary<string, int> dic = new Dictionary<string, int>();");
                foreach (KeyValuePair<string, int> d in dic)
                {
                    // Se añaden los valores al gráfico
                    int indice = chart1.Series["Nº pedidos"].Points.AddXY(d.Key, d.Value);
                    // Se coloca un tool tip a cada punto para mostrar los datos más grandes
                    chart1.Series["Nº pedidos"].Points[indice].ToolTip = String.Format("{0} ({1})", d.Key, d.Value);
                }
            } 
            
        }
    }
}
