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
    public class SupplierADO : IDisposable
    {
        bool disposed;

        public SupplierADO()
        {
            disposed = false;
        }

        public static List<Supplier> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Suppliers.ToList();
                return data;
            }
        }

        public Supplier Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Suppliers
                            where st.SupplierId == id
                            select st;

                var supplier = query.FirstOrDefault<Supplier>();
                return supplier;
            }
        }

        public void Insertar(Supplier dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Supplier modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Supplier dato)
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
