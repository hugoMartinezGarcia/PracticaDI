using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Printing;
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
        private Employee usuario;
        private MainWindow mainWindow;
        private Order pedido;
        public UCFactura(MainWindow mainWindow, Employee usuario, Order pedido)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.usuario = usuario;
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


        // Método para mostrar el diálogo para imprimir
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

                Retroceder();
            }
        }

        private void btAtras_Click(object sender, RoutedEventArgs e)
        {
            Retroceder();   
        }

        private void Retroceder()
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCBuscarPedido(usuario, mainWindow, true));
        }
    }
}
