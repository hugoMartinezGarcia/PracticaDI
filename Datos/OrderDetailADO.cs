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
    public class OrderDetailADO : IDisposable
    {
        bool disposed;

        public OrderDetailADO()
        {
            disposed = false;
        }

        public static List<OrderDetail> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.OrderDetails.ToList();
                return data;
            }
        }

        public OrderDetail Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.OrderDetails
                            where st.OrderId == id
                            select st;

                var orderDetail = query.FirstOrDefault<OrderDetail>();
                return orderDetail;
            }
        }

        public void Insertar(OrderDetail dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(OrderDetail modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(OrderDetail dato)
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
