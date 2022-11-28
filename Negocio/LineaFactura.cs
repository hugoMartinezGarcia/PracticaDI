using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LineaFactura
    {
        public string Producto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public float Descuento { get; set; }

        public decimal PrecioFinal => PrecioUnitario * Cantidad * (1 - (decimal)Descuento);

        public LineaFactura()
        {
            Producto = "";
            PrecioUnitario = 1;
            Cantidad = 1;
            Descuento = 0;
        }

        public LineaFactura(OrderDetail orderDetail) : this()
        {
            Producto = orderDetail.Product.ProductName;
            PrecioUnitario = orderDetail.UnitPrice;
            Cantidad = orderDetail.Quantity;
            Descuento = orderDetail.Discount;
        }
    }
}
