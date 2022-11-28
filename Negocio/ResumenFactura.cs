using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ResumenFactura
    {
        public decimal Precio {get; set;}
        public decimal IVA { get; set;}
        public decimal Total { get; set;}

        public ResumenFactura(decimal precio, decimal iva)
        {
            Precio = precio;
            IVA = iva;
            Total = Precio + (Precio * IVA / 100);
        }

        public ResumenFactura()  : this(1, 16) { }
    }
}
