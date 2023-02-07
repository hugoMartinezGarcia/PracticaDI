using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para UCFactura.xaml
    /// </summary>
    public partial class UCFactura : UserControl
    {
        private Order pedido;
        public UCFactura(Order pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            using (Gestion g = new Gestion())
            {
                gridCabecera.DataContext = new ResumenPedido(pedido);
            }
            List<LineaFactura> lineasFactura = new List<LineaFactura>();
            
            pedido.OrderDetails.ToList().ForEach(od => lineasFactura.Add(new LineaFactura(od)));

            dgDetallesFactura.DataContext = lineasFactura;

            gridResumenFactura.DataContext = Gestion.ResumenFactura(pedido.OrderDetails.ToList());
        }


        private void btImprimir_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument flowDocument = flowDocumentViewer.Document;
                flowDocument.PageHeight = printDialog.PrintableAreaHeight;
                flowDocument.PageWidth = printDialog.PrintableAreaWidth;
                flowDocument.PagePadding = new Thickness(25);
                flowDocument.ColumnGap = 0;
                flowDocument.ColumnWidth = printDialog.PrintableAreaWidth;

                IDocumentPaginatorSource document = flowDocument as IDocumentPaginatorSource;
                printDialog.PrintDocument(document.DocumentPaginator, "Factura NORTHWIND  Nº: " + pedido.OrderId);



            }
        }
    }
}
