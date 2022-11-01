///<author>Hugo Martínez</author>

using Entidades;
using Microsoft.EntityFrameworkCore;


namespace Datos
{
    public class CustomerADO : IDisposable
    {
        bool disposed;

        public CustomerADO()
        {
            disposed = false;
        }

        public static List<Customer> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Customers.ToList();
                return data;
            }
        }

        public Customer Listar(string id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Customers
                            where st.CustomerId == id
                            select st;

                var customer = query.FirstOrDefault<Customer>();
                return customer;
            }
        }

        public void Insertar(Customer dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Customer modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Customer dato)
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
