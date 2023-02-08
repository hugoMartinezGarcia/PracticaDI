///<author>Hugo Martínez</author>

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [Index("LastName", Name = "LastName")]
    [Index("PostalCode", Name = "PostalCode")]
    public partial class Employee : IComparable<Employee>, IDisposable, INotifyPropertyChanged
    {
        private int employeeId;
        private string lastName = null!;
        private string firstName = null!;
        private string? title;
        private string? titleOfCourtesy;
        private DateTime? birthDate;
        private DateTime? hireDate;
        private string? address;
        private string? city;
        private string? region;
        private string? postalCode;
        private string? country;
        private string? homePhone;
        private string? extension;
        private byte[]? photo;
        private string? notes;
        private int? reportsTo;
        private string? photoPath;
        private Employee? reportsToNavigation;
        private ICollection<Employee> inverseReportsToNavigation;
        private ICollection<Order> orders;

        bool disposed;

        [Key]
        [Column("EmployeeID")]
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }
        [StringLength(20)]
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }
        [StringLength(10)]
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }
        [StringLength(30)]
        public string? Title 
        { 
            get
            {
                return title;
            }
            set
            {
                title = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(25)]
        public string? TitleOfCourtesy { get
            {
                return titleOfCourtesy;
            }
            set
            {
                titleOfCourtesy = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            } 
        }
        [StringLength(60)]
        public string? Address { get
            {
                return address;
            }
            set
            {
                address = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(15)]
        public string? City { get
            {
                return city;
            }
            set
            {
                city = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(15)]
        public string? Region { get
            {
                return region;
            }
            set
            {
                region = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(10)]
        public string? PostalCode { get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            } 
        }
        [StringLength(15)]
        public string? Country { get
            {
                return country;
            }
            set
            {
                country = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(24)]
        public string? HomePhone { get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(4)]
        public string? Extension { get
            {
                return extension;
            }
            set
            {
                extension = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }
        [Column(TypeName = "image")]
        public byte[]? Photo { get
            {
                return photo;
            }
            set
            {
                photo = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        public string? Notes { get
            {
                return notes;
            }
            set
            {
                notes = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }
        public int? ReportsTo { get
            {
                return reportsTo;
            }
            set
            {
                reportsTo = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [StringLength(255)]
        public string? PhotoPath { get
            {
                return photoPath;
            }
            set
            {
                photoPath = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }

        [ForeignKey("ReportsTo")]
        [InverseProperty("InverseReportsToNavigation")]
        public virtual Employee? ReportsToNavigation { get
            {
                return reportsToNavigation;
            }
            set
            {
                reportsToNavigation = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [InverseProperty("ReportsToNavigation")]
        public virtual ICollection<Employee> InverseReportsToNavigation { get
            {
                return inverseReportsToNavigation;
            }
            set
            {
                inverseReportsToNavigation = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        [InverseProperty("Employee")]
        public virtual ICollection<Order> Orders { get
            {
                return orders;
            }
            set
            {
                orders = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            } 
        }
        

        public event PropertyChangedEventHandler? PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

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
