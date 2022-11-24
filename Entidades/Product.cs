///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Entidades
{
    [Index("CategoryId", Name = "CategoriesProducts")]
    [Index("CategoryId", Name = "CategoryID")]
    [Index("ProductName", Name = "ProductName")]
    [Index("SupplierId", Name = "SupplierID")]
    [Index("SupplierId", Name = "SuppliersProducts")]
    public partial class Product : IDisposable
    {
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Column("SupplierID")]
        public int? SupplierId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(20)]
        public string? QuantityPerUnit { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Products")]
        public virtual Category? Category { get; set; }
        [ForeignKey("SupplierId")]
        [InverseProperty("Products")]
        public virtual Supplier? Supplier { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        bool disposed;

        public Product()
        {
            ProductId = 0;
            ProductName = "productName";
            SupplierId = null;
            CategoryId = null;
            QuantityPerUnit = null;
            UnitPrice = null;
            UnitsInStock = null;
            UnitsOnOrder = null;
            ReorderLevel = null;
            Discontinued = false;
            Category = null;
            Supplier = null;
            OrderDetails = new HashSet<OrderDetail>();
            disposed = false;
        }
        
        public Product(int productId, string productName, bool discontinued, ICollection<OrderDetail> orderDetails)
            : this()
        {
            ProductId = productId;
            ProductName = productName;
            Discontinued = discontinued;
            OrderDetails = orderDetails;
        }
        
        public Product(int productId, string productName, int? supplierId, int? categoryId, 
            string? quantityPerUnit, decimal? unitPrice, short? unitsInStock, short? unitsOnOrder, 
            short? reorderLevel, bool discontinued, Category? category, Supplier? supplier, 
            ICollection<OrderDetail> orderDetails)
            : this(productId, productName, discontinued, orderDetails)
        {
            SupplierId = supplierId;
            CategoryId = categoryId;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Category = category;
            Supplier = supplier;
        }

        public override string ToString()
        {
            /*
            return ProductId + "#" + ProductName + "#" + SupplierId + "#" + CategoryId + "#" +
                QuantityPerUnit + "#" + UnitPrice + "#" + UnitsInStock + "#" + UnitsOnOrder + "#" +
                ReorderLevel + "#" + Discontinued + "#" + Category?.CategoryId + "#" + 
                Supplier?.SupplierId + "#" + OrderDetails.Count;
            */
            return ProductName; 
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
