using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DatosDashboard
    {
        public int PedidosUsuarioUltimoMes { get; set; }
        public int ProductosStock10 { get; set; }
        public decimal ImportePedidosHoy { get; set; }
        public decimal ImportePedidosUsuHoy { get; set; }
        public Dictionary<string, int> SeriePedidosCliente { get; set; }

        public Dictionary<string, int> SerieProductosPorCategoria { get; set; }

        public DateTime HoraActual { get; set; }

        public DatosDashboard()
        {
            PedidosUsuarioUltimoMes = 0;
            ProductosStock10 = 0;
            ImportePedidosHoy = 0;
            ImportePedidosUsuHoy = 0;
            SeriePedidosCliente = new Dictionary<string, int>();
            SerieProductosPorCategoria = new Dictionary<string, int>();
            HoraActual = DateTime.Now;
        }

        public DatosDashboard(int pedidosUsuarioUltimoMes, int productosStock10, decimal importePedidosHoy, 
            decimal importePedidoUsuHoy, Dictionary<string, int> seriePedidosCliente, Dictionary<string, int> serieProductosPorCategoria, DateTime horaActual)
        {
            PedidosUsuarioUltimoMes = pedidosUsuarioUltimoMes;
            ProductosStock10 = productosStock10;
            ImportePedidosHoy = importePedidosHoy;
            ImportePedidosUsuHoy = importePedidoUsuHoy;
            SeriePedidosCliente = seriePedidosCliente;
            SerieProductosPorCategoria = serieProductosPorCategoria;
            HoraActual = horaActual;
        }
    }
}
