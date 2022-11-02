///<author>Hugo Martínez</author>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [Index("LastName", Name = "LastName")]
    [Index("PostalCode", Name = "PostalCode")]
    public partial class Employee : IComparable<Employee>, IDisposable
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [StringLength(20)]
        public string LastName { get; set; } = null!;
        [StringLength(10)]
        public string FirstName { get; set; } = null!;
        [StringLength(30)]
        public string? Title { get; set; }
        [StringLength(25)]
        public string? TitleOfCourtesy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
        [StringLength(60)]
        public string? Address { get; set; }
        [StringLength(15)]
        public string? City { get; set; }
        [StringLength(15)]
        public string? Region { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(15)]
        public string? Country { get; set; }
        [StringLength(24)]
        public string? HomePhone { get; set; }
        [StringLength(4)]
        public string? Extension { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int? ReportsTo { get; set; }
        [StringLength(255)]
        public string? PhotoPath { get; set; }

        [ForeignKey("ReportsTo")]
        [InverseProperty("InverseReportsToNavigation")]
        public virtual Employee? ReportsToNavigation { get; set; }
        [InverseProperty("ReportsToNavigation")]
        public virtual ICollection<Employee> InverseReportsToNavigation { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Order> Orders { get; set; }

        bool disposed;

        public Employee()
        {
            EmployeeId = 0;
            LastName = "lastName";
            FirstName = "firstName";
            Title = null;
            TitleOfCourtesy = null;
            BirthDate = null;
            HireDate = null;
            Address = null;
            City = null;
            Region = null;
            PostalCode = null;
            Country = null;
            HomePhone = null;
            Extension = null;
            Photo = new byte[1];
            Notes = null;
            ReportsTo = null;
            PhotoPath = null;
            ReportsToNavigation = null;
            InverseReportsToNavigation = new HashSet<Employee>();
            Orders = new HashSet<Order>();
            disposed = false;
        }

        public Employee(int employeeId, string lastName, string firstName, 
            ICollection<Employee> inverseReportsToNavigation, ICollection<Order> orders)
            : this()
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;
            InverseReportsToNavigation = inverseReportsToNavigation;
            Orders = orders;
        }

        public Employee(int employeeId, string lastName, string firstName, string? title, 
            string? titleOfCourtesy, DateTime? birthDate, DateTime? hireDate, string? address, 
            string? city, string? region, string? postalCode, string? country, string? homePhone, 
            string? extension, byte[]? photo, string? notes, int? reportsTo, string? photoPath, 
            Employee? reportsToNavigation, ICollection<Employee> inverseReportsToNavigation, 
            ICollection<Order> orders)
            : this(employeeId, lastName, firstName, inverseReportsToNavigation, orders)
        {
            Title = title;
            TitleOfCourtesy = titleOfCourtesy;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            HomePhone = homePhone;
            Extension = extension;
            Photo = photo;
            Notes = notes;
            ReportsTo = reportsTo;
            PhotoPath = photoPath;
            ReportsToNavigation = reportsToNavigation;
        }

        // Constructor de copia
        public Employee(Employee otro)
        {
            EmployeeId = otro.EmployeeId;
            LastName = otro.LastName;
            FirstName = otro.FirstName;
            Title = otro.Title;
            TitleOfCourtesy = otro.TitleOfCourtesy;
            BirthDate = otro.BirthDate;
            HireDate = otro.HireDate;
            Address = otro.Address;
            City = otro.City;
            Region = otro.Region;
            PostalCode = otro.PostalCode;
            Country = otro.Country;
            HomePhone = otro.HomePhone;
            Extension = otro.Extension;
            Photo = otro.Photo;
            Notes = otro.Notes;
            ReportsTo = otro.ReportsTo;
            PhotoPath = otro.PhotoPath;
            // Lo copia solo si no es null
            ReportsToNavigation = otro.ReportsToNavigation != null ?
                new Employee(otro.ReportsToNavigation) : null; 
            InverseReportsToNavigation = new HashSet<Employee>(otro.InverseReportsToNavigation);
            Orders = new HashSet<Order>(otro.Orders);
        }

        public int CompareTo(Employee? otro)
        {
            // Si el otro objeto es null, entonces este es mayor
            if (otro == null)
                return 1;

            int resultado = FirstName.CompareTo(otro.FirstName);

            // Si tienen el mismo FirstName se comprueba el LastName
            if (resultado == 0)
                resultado = LastName.CompareTo(otro.LastName);

            return resultado;          
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            return EmployeeId + "#" + LastName + "#" + FirstName + "#" + Title + "#" + TitleOfCourtesy + "#" +
                BirthDate + "#" + HireDate + "#" + Address + "#" + City + "#" + Region + "#" +
                PostalCode + "#" + Country + "#" + HomePhone + "#" + Extension + "#" + Photo + "#" +
                Notes + "#" + ReportsTo + "#" + PhotoPath + "#" + ReportsToNavigation?.EmployeeId + "#" +
                InverseReportsToNavigation.Count + "#" + Orders.Count;
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
