using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ResumenPedido
    {
        public int OrderId { get; set; }
        public string? Customer { get; set; }
        public string? Employee { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set;}
        public string? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set;}
        public string? ShipCountry { get; set; }

        public ResumenPedido()
        {
            OrderId = 1;
            Customer = null;
            Employee = null;
            OrderDate = null;
            RequiredDate = null;
            ShippedDate = null;
            ShipVia = null;
            Freight = null;
            ShipName = null;
            ShipAddress = null;
            ShipCity = null;
            ShipRegion = null;
            ShipPostalCode = null;
            ShipCountry = null;
        }

        public ResumenPedido (Order order)
        {
            OrderId = order.OrderId;
            Customer = order.Customer != null ? order.Customer.CompanyName : null;
            Employee = order.Employee != null ? order.Employee.FirstName + " " + order.Employee.LastName : null;
            OrderDate = order.OrderDate;
            RequiredDate = order.RequiredDate;
            ShippedDate = order.ShippedDate;
            ShipVia = order.ShipViaNavigation != null ? order.ShipViaNavigation.CompanyName : null;
            Freight = order.Freight;
            ShipName = order.ShipName;
            ShipAddress = order.ShipAddress;
            ShipCity = order.ShipCity;
            ShipRegion = order.ShipRegion;
            ShipPostalCode = order.ShipPostalCode;
            ShipCountry = order.ShipCountry;
        }
    }
}
