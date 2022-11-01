///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public partial class Shipper : IDisposable
    {
        [Key]
        [Column("ShipperID")]
        public int ShipperId { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [StringLength(24)]
        public string? Phone { get; set; }

        [InverseProperty("ShipViaNavigation")]
        public virtual ICollection<Order> Orders { get; set; }

        bool disposed;

        public Shipper()
        {
            ShipperId = 0;
            CompanyName = "companyName";
            Phone = null;
            Orders = new HashSet<Order>();
            disposed = false;
        }

        public Shipper(int shipperId, string companyName, ICollection<Order> orders)
            : this()
        {
            ShipperId = shipperId;
            CompanyName = companyName;
            Orders = orders;
        }

        public Shipper(int shipperId, string companyName, string? phone, ICollection<Order> orders)
            : this(shipperId, companyName, orders)
        {
            Phone = phone;
        }

        public Shipper(Shipper otro)
        {
            ShipperId = otro.ShipperId;
            CompanyName = otro.CompanyName;
            Phone = otro.Phone;
            Orders = new HashSet<Order>(otro.Orders);
        }

        public override string ToString()
        {
            return ShipperId + "#" + CompanyName + "#" + Phone + "#" + Orders.Count;
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
