///<author>Hugo Martínez</author>

using Entidades;
using Microsoft.EntityFrameworkCore;


namespace Datos
{
    public class CategoryADO : IDisposable
    {
        bool disposed;

        public CategoryADO()
        {
            disposed = false;
        }

        public static List<Category> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Categories.ToList();
                return data;
            }
        }

        public Category Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Categories
                            where st.CategoryId == id
                            select st;

                var category = query.FirstOrDefault<Category>();
                return category;
            }
        }

        public void Insertar(Category dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Category modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Category dato)
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
