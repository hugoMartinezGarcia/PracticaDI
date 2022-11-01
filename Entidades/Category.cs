///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [Index("CategoryName", Name = "CategoryName")]
    public partial class Category : IDisposable
    {
        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Picture { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Product> Products { get; set; }

        bool disposed;

        public Category()
        {
            // Si se pasa un id distinto de 0 falla la inserción porque (SET IDENTITY_INSERT tableName OFF)
            CategoryId = 0;
            CategoryName = "categoryName";
            Description = null;
            Picture = null;
            Products = new HashSet<Product>();
            disposed = false;
        }

        public Category(int categoryId, string categoryName, ICollection<Product> products) 
            : this()
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Products = products;
        }

        public Category(int categoryId, string categoryName, string? description, 
            byte[]? picture, ICollection<Product> products) 
            : this(categoryId, categoryName, products)
        { 
            Description = description;
            Picture = picture; 
        }     

        public override string ToString()
        {
            return CategoryId + "#" + CategoryName + "#" + Description + "#" + Products.Count;
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
