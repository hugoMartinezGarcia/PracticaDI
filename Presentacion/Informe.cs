using Entidades;
using Microsoft.Reporting.WinForms;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Informe
    {
        public static void Load(LocalReport report, Order order)
        {
            List<LineaFactura> lineas = new List<LineaFactura>();
            order.OrderDetails.ToList().ForEach(od => lineas.Add(new LineaFactura(od)));
            
            var lineasFactura =  lineas;
            var resumenFactura = new[] { Gestion.ResumenFactura(order.OrderDetails.ToList()) };
            var resumenPedido = new[] { new ResumenPedido(order)};
            var titulo = new[] { new ReportParameter("Titulo", "FACTURA NORTHWIND") };
            using var fs = new FileStream("informe.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("DatosLineas", lineasFactura));
            report.DataSources.Add(new ReportDataSource("DatosResumen", resumenFactura));
            report.DataSources.Add(new ReportDataSource("DatosPedido", resumenPedido));
            report.SetParameters(titulo);
            byte[] pdf = report.Render("PDF");
        }
    }
}
