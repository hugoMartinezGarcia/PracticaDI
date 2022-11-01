///<author>Hugo Martínez</author>

using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductADO : IDisposable
    {
        bool disposed;

        public ProductADO()
        {
            disposed = false;
        }

        public static List<Product> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Products.ToList();
                return data;
            }
        }

        public Product Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Products
                            where st.ProductId == id
                            select st;

                var product = query.FirstOrDefault<Product>();
                return product;
            }
        }

        public void Insertar(Product dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Product modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Product dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Deleted;
                context.SaveChanges();
            }
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
