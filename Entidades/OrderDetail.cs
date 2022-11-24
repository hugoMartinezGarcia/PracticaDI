///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [Table("Order Details")]
    [Index("OrderId", Name = "OrderID")]
    [Index("OrderId", Name = "OrdersOrder_Details")]
    [Index("ProductId", Name = "ProductID")]
    [Index("ProductId", Name = "ProductsOrder_Details")]
    public partial class OrderDetail : IDisposable
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; } = null!;
        [ForeignKey("ProductId")]
        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; } = null!;

        bool disposed;

        public OrderDetail()
        {
            OrderId = 10248;
            ProductId = 1;
            UnitPrice = 1;
            Quantity = 1;
            Discount = 0;
            Order = new Order();
            Product = new Product();
            disposed = false;
        }


        public OrderDetail(int orderId, int productId, decimal unitPrice, 
            short quantity, float discount, Order order, Product product)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
            Order = order;
            Product = product;
        }
        
        public override string ToString()
        {
            return OrderId + "#" + ProductId + "#" + UnitPrice + "#" + Quantity + "#" + 
                Discount + "#" + Order.OrderId + "#" + Product.ProductId;
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
