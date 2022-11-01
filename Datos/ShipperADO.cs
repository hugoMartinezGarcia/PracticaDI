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
    public class ShipperADO : IDisposable
    {
        bool disposed;

        public ShipperADO()
        {
            disposed = false;
        }

        public static List<Shipper> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Shippers.ToList();
                return data;
            }
        }

        public Shipper Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Shippers
                            where st.ShipperId == id
                            select st;

                var shipper = query.FirstOrDefault<Shipper>();
                return shipper;
            }
        }

        public void Insertar(Shipper dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Shipper modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Shipper dato)
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
