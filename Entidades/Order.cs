///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [Index("CustomerId", Name = "CustomerID")]
    [Index("CustomerId", Name = "CustomersOrders")]
    [Index("EmployeeId", Name = "EmployeeID")]
    [Index("EmployeeId", Name = "EmployeesOrders")]
    [Index("OrderDate", Name = "OrderDate")]
    [Index("ShipPostalCode", Name = "ShipPostalCode")]
    [Index("ShippedDate", Name = "ShippedDate")]
    [Index("ShipVia", Name = "ShippersOrders")]
    public partial class Order : IDisposable
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("CustomerID")]
        [StringLength(5)]
        public string? CustomerId { get; set; }
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }
        [StringLength(40)]
        public string? ShipName { get; set; }
        [StringLength(60)]
        public string? ShipAddress { get; set; }
        [StringLength(15)]
        public string? ShipCity { get; set; }
        [StringLength(15)]
        public string? ShipRegion { get; set; }
        [StringLength(10)]
        public string? ShipPostalCode { get; set; }
        [StringLength(15)]
        public string? ShipCountry { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Orders")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("EmployeeId")]
        [InverseProperty("Orders")]
        public virtual Employee? Employee { get; set; }
        [ForeignKey("ShipVia")]
        [InverseProperty("Orders")]
        public virtual Shipper? ShipViaNavigation { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        bool disposed;

        public Order()
        {
            OrderId = 0;
            CustomerId = null;
            EmployeeId = null;
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
            Customer = null;
            Employee = null;
            ShipViaNavigation = null;
            OrderDetails = new HashSet<OrderDetail>();
            disposed = false;
        }

        public Order(int orderId, ICollection<OrderDetail> orderDetails) 
            : this()
        {
            OrderId = orderId;
            OrderDetails = orderDetails;
        }

        public Order(int orderId, string? customerId, int? employeeId, DateTime? orderDate, 
            DateTime? requiredDate, DateTime? shippedDate, int? shipVia, decimal? freight, 
            string? shipName, string? shipAddress, string? shipCity, string? shipRegion, 
            string? shipPostalCode, string? shipCountry, Customer? customer, Employee? employee, 
            Shipper? shipViaNavigation, ICollection<OrderDetail> orderDetails)
            : this(orderId, orderDetails)
        {
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipVia = shipVia;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
            Customer = customer;
            Employee = employee;
            ShipViaNavigation = shipViaNavigation;
        }

        public Order(Order otro)
        {
            OrderId = otro.OrderId;
            CustomerId = otro.CustomerId;
            EmployeeId = otro.EmployeeId;
            OrderDate = otro.OrderDate;
            RequiredDate = otro.RequiredDate;
            ShippedDate = otro.ShippedDate;
            ShipVia = otro.ShipVia;
            Freight = otro.Freight;
            ShipName = otro.ShipName;
            ShipAddress = otro.ShipAddress;
            ShipCity = otro.ShipCity;
            ShipRegion = otro.ShipRegion;
            ShipPostalCode = otro.ShipPostalCode;
            ShipCountry = otro.ShipCountry;
            Customer = otro.Customer;
            Employee = otro.Employee;
            // Lo copia solo si no es null
            ShipViaNavigation = otro.ShipViaNavigation != null ?
                new Shipper(otro.ShipViaNavigation) : null;
            OrderDetails = new HashSet<OrderDetail>(otro.OrderDetails);
        }

        public override string ToString()
        {
            return OrderId + "#" + CustomerId + "#" + EmployeeId + "#" + OrderDate + "#" + 
                RequiredDate + "#" + ShippedDate + "#" + ShipVia + "#" + Freight + "#" + 
                ShipName + "#" + ShipAddress + "#" + ShipCity + "#" + ShipRegion + "#" + 
                ShipPostalCode + "#" + ShipCountry + "#" + Customer?.CustomerId + "#" + 
                Employee?.EmployeeId + "#" + ShipViaNavigation?.ShipperId + "#" + OrderDetails.Count;
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //Liberar recursos no manejados como ficheros, conexiones a bd, etc.
            }

            disposed = true;
        }
    }
}
