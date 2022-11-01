///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [Index("CompanyName", Name = "CompanyName")]
    [Index("PostalCode", Name = "PostalCode")]
    public partial class Supplier : IDisposable
    {
        [Key]
        [Column("SupplierID")]
        public int SupplierId { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [StringLength(30)]
        public string? ContactName { get; set; }
        [StringLength(30)]
        public string? ContactTitle { get; set; }
        [StringLength(60)]
        public string? Address { get; set; }
        [StringLength(15)]
        public string? City { get; set; }
        [StringLength(15)]
        public string? Region { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(15)]
        public string? Country { get; set; }
        [StringLength(24)]
        public string? Phone { get; set; }
        [StringLength(24)]
        public string? Fax { get; set; }
        public string? HomePage { get; set; }

        [InverseProperty("Supplier")]
        public virtual ICollection<Product> Products { get; set; }

        bool disposed;

        public Supplier()
        {
            SupplierId = 0;
            CompanyName = "companyName";
            ContactName = null;
            ContactTitle = null;
            Address = null;
            City = null;
            Region = null;
            PostalCode = null;
            Country = null;
            Phone = null;
            Fax = null;
            HomePage = null;
            Products = new HashSet<Product>();
            disposed = false;
        }

        public Supplier(int supplierId, string companyName, ICollection<Product> products)
            : this()
        {
            SupplierId = supplierId;
            CompanyName = companyName;
            Products = products;
        }

        public Supplier(int supplierId, string companyName, string? contactName, string? contactTitle, 
            string? address, string? city, string? region, string? postalCode, string? country, 
            string? phone, string? fax, string? homePage, ICollection<Product> products)
            : this(supplierId, companyName, products)
        {
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
            HomePage = homePage;
        }

        public override string ToString()
        {
            return SupplierId + "#" + CompanyName + "#" + ContactName + "#" + ContactTitle + "#" +
                Address + "#" + City + "#" + Region + "#" + PostalCode + "#" + Country + "#" +
                Phone + "#" + Fax + "#" + HomePage + "#" + Products.Count;
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
