using Entidades;
using Microsoft.Reporting.WinForms;
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
    public partial class FormFactura : Form
    {
        private Order order;
        private readonly ReportViewer reportViewer;
        public FormFactura(Order order)
        {
            InitializeComponent();
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            //ReportItemSchemas();
            this.order = order;
        }

        protected override void OnLoad(EventArgs e)
        {
            Informe.Load(reportViewer.LocalReport, order);
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }

        private void ReportItemSchemas()
        {
            var types = new[] { typeof(Informe), typeof(ResumenFactura), typeof(LineaFactura), typeof(ResumenPedido)};
            var xri = new System.Xml.Serialization.XmlReflectionImporter();
            var xss = new System.Xml.Serialization.XmlSchemas();
            var xse = new System.Xml.Serialization.XmlSchemaExporter(xss);
            foreach (var type in types)
            {
                var xtm = xri.ImportTypeMapping(type);
                xse.ExportTypeMapping(xtm);
            }
            using var sw = new System.IO.StreamWriter("ReportItemSchemas.xsd", false, Encoding.UTF8);
            for (int i = 0; i < xss.Count; i++)
            {
                var xs = xss[i];
                xs.Id = "ReportItemSchemas";
                xs.Write(sw);
            }
        }
    }
}
