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
    public class OrderADO : IDisposable
    {
        bool disposed;

        public OrderADO()
        {
            disposed = false;
        }

        public static List<Order> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Orders.ToList();
                return data;
            }
        }

        public Order Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.OrderId == id
                            select st;

                var order = query.FirstOrDefault<Order>();
                return order;
            }         
        }

        public List<Order> ListarPorCustomerId(string customerId)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Orders
                            where st.CustomerId == customerId
                            select st;

                var orders = query.ToList();
                return orders;
            }
        }

        public void Insertar(Order dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Order modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Order dato)
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
