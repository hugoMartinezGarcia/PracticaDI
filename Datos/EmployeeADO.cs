///<author>Hugo Martínez</author>

using Microsoft.EntityFrameworkCore;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmployeeADO : IDisposable
    {
        bool disposed;

        public EmployeeADO()
        {
            disposed = false;
        }

        public static List<Employee> Listar()
        {
            using (var context = new NorthwindContext())
            {
                var data = context.Employees.ToList();
                return data;
            }
        }

        public Employee Listar(int id)
        {
            using (var context = new NorthwindContext())
            {
                var query = from st in context.Employees
                            where st.EmployeeId == id
                            select st;

                var employee = query.FirstOrDefault<Employee>();
                return employee;
            }
        }

        public void Insertar(Employee dato)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(dato).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Actualizar(Employee modificado)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(Employee dato)
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
