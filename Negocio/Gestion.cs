///<author>Hugo Martínez</author>

using Entidades;
using Datos;
using System.Linq;

namespace Negocio
{
    public class Gestion : IDisposable
    {
        List<Employee> Empleados { get; set; }
        List<Order> Pedidos { get; set; }
        // Flag: Has Dispose already been called?
        bool disposed;

        public Gestion()
        {
            Empleados = new List<Employee>();
            Pedidos = new List<Order>();
            // Flag: Has Dispose already been called?
            disposed = false;
        }

        public Gestion(List<Employee> empleados, List<Order> pedidos)
        {
            Empleados = empleados;
            Pedidos = pedidos;
        }

        public Gestion(Gestion otro)
        {
            Empleados = new List<Employee>(otro.Empleados);
            Pedidos = new List<Order>(otro.Pedidos);
        }

        // Método para listar los Orders de un Employee
        public List<Order> ListarPedidosEmpleado(int employeeId)
        {
            return OrderADO.Listar().Where(cO => cO.EmployeeId == employeeId).ToList();
        }
        
        // Método para mostrar todos los datos de un pedido, incluyendo OrderDetails y Products
        public Order DatosPedido(int orderId)
        {
            Order order = new Order();
            // Se obtiene un Order de la tabla a partir de su id
            using (OrderADO o = new OrderADO())
            {
                order = o.Listar(orderId);
            }

            if (order != null)
            {
                List<OrderDetail> listaOD = OrderDetailADO.Listar();
                // Se añade al Order el listado de OrderDetails
                foreach (OrderDetail d in listaOD.Where(d => d.OrderId == orderId))
                {
                    order.OrderDetails.Add(d);
                }   
                // Se añade a cada OrderDetail el Producto
                using (ProductADO p = new ProductADO())
                {
                    order.OrderDetails
                    .ToList()
                    .ForEach(o => o.Product = p.Listar(o.ProductId));
                }
            }

            return order;
        }

        // Devuelve los pedidos de un cliente apoyándose en DatosPedido(int orderId)
        public List<Order> ListarPedidosCliente(string customerId)
        {
            List<Order> customerOrders = new List<Order>();
            List<Order> orders = new List<Order>();
            // Se obtiene una lista de Orders a partir del CustomerId
            customerOrders = OrderADO.Listar()
                .Where(cO => cO.CustomerId == customerId.ToUpper()).ToList();

            if (customerOrders.Count > 0)
            {
                // Se rellena una nueva lista de Orders empleando el método DatosPedido(int id)
                orders.AddRange(from Order or in customerOrders
                                select DatosPedido(or.OrderId));
            }

            return orders;
        }
        
        public override string ToString()
        {
            return String.Join("-", Empleados)
                + "#"
                + String.Join("-", Pedidos);
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



        //-------------------------- MÉTODOS CRUD ---------------------------//

        // CATEGORY
        public static List<Category> ListarCategory()
        {
            return CategoryADO.Listar();
        }

        public Category BuscarCategory(int id)
        {
            Category cat = new Category();

            using (CategoryADO c = new CategoryADO())
            {
                cat = c.Listar(id);
            }

            return cat;
        }

        public void InsertarCategory(Category category)
        {
            using (CategoryADO c = new CategoryADO())
            {
                c.Insertar(category);
            }
        }

        public void ActualizarCategory(Category category)
        {
            using (CategoryADO c = new CategoryADO())
            {
                c.Actualizar(category);
            }
        }

        public void BorrarCategory(Category category)
        {
            using (CategoryADO c = new CategoryADO())
            {
                c.Borrar(category);
            }
        }

        // CUSTOMER
        public static List<Customer> ListarCustomer()
        {
            return CustomerADO.Listar();
        }

        public Customer BuscarCustomer(string id)
        {
            Customer cus = new Customer();

            using (CustomerADO c = new CustomerADO())
            {
                cus = c.Listar(id);
            }

            return cus;
        }

        public void InsertarCustomer(Customer customer)
        {
            using (CustomerADO c = new CustomerADO())
            {
                c.Insertar(customer);
            }
        }

        public void ActualizarCustomer(Customer customer)
        {
            using (CustomerADO c = new CustomerADO())
            {
                c.Actualizar(customer);
            }
        }

        public void BorrarCustomer(Customer customer)
        {
            using (CustomerADO c = new CustomerADO())
            {
                c.Borrar(customer);
            }
        }

        // EMPLOYEE
        public static List<Employee> ListarEmployee()
        {
            return EmployeeADO.Listar();
        }

        public Employee BuscarEmployee(int id)
        {
            Employee emp = new Employee();

            using (EmployeeADO e = new EmployeeADO())
            {
                emp = e.Listar(id);
            }

            return emp;
        }

        public void InsertarEmployee(Employee employee)
        {
            using (EmployeeADO c = new EmployeeADO())
            {
                c.Insertar(employee);
            }
        }

        public void ActualizarEmployee(Employee employee)
        {
            using (EmployeeADO c = new EmployeeADO())
            {
                c.Actualizar(employee);
            }
        }

        public void BorrarEmployee(Employee employee)
        {
            using (EmployeeADO c = new EmployeeADO())
            {
                c.Borrar(employee);
            }
        }

        // ORDER
        public static List<Order> ListarOrder()
        {
            return OrderADO.Listar();
        }

        public Order BuscarOrder(int id)
        {
            Order ord = new Order();

            using (OrderADO c = new OrderADO())
            {
                ord = c.Listar(id);
            }

            return ord;
        }

        public void InsertarOrder(Order order)
        {
            using (OrderADO c = new OrderADO())
            {
                c.Insertar(order);
            }
        }

        public void ActualizarOrder(Order order)
        {
            using (OrderADO c = new OrderADO())
            {
                c.Actualizar(order);
            }
        }

        public void BorrarOrder(Order order)
        {
            using (OrderADO c = new OrderADO())
            {
                c.Borrar(order);
            }
        }

        // ORDER DETAIL
        public static List<OrderDetail> ListarOrderDetail()
        {
            return OrderDetailADO.Listar();
        }

        public OrderDetail BuscarOrderDetail(int id)
        {
            OrderDetail orDet = new OrderDetail();

            using (OrderDetailADO c = new OrderDetailADO())
            {
                orDet = c.Listar(id);
            }

            return orDet;
        }

        public void InsertarOrderDetail(OrderDetail orderDetail)
        {
            using (OrderDetailADO o = new OrderDetailADO())
            {
                o.Insertar(orderDetail);
            }
        }

        public void ActualizarOrderDetail(OrderDetail orderDetail)
        {
            using (OrderDetailADO c = new OrderDetailADO())
            {
                c.Actualizar(orderDetail);
            }
        }

        public void BorrarOrderDetail(OrderDetail orderDetail)
        {
            using (OrderDetailADO c = new OrderDetailADO())
            {
                c.Borrar(orderDetail);
            }
        }

        // PRODUCT
        public static List<Product> ListarProduct()
        {
            return ProductADO.Listar();
        }

        public Product BuscarProduct(int id)
        {
            Product pro = new Product();

            using (ProductADO c = new ProductADO())
            {
                pro = c.Listar(id);
            }

            return pro;
        }

        public void InsertarProduct(Product product)
        {
            using (ProductADO c = new ProductADO())
            {
                c.Insertar(product);
            }
        }

        public void ActualizarProduct(Product product)
        {
            using (ProductADO c = new ProductADO())
            {
                c.Actualizar(product);
            }
        }

        public void BorrarProduct(Product product)
        {
            using (ProductADO c = new ProductADO())
            {
                c.Borrar(product);
            }
        }

        // SHIPPER
        public static List<Shipper> ListarShipper()
        {
            return ShipperADO.Listar();
        }

        public Shipper BuscarShipper(int id)
        {
            Shipper ship = new Shipper();

            using (ShipperADO c = new ShipperADO())
            {
                ship = c.Listar(id);
            }

            return ship;
        }

        public void InsertarShipper(Shipper shipper)
        {
            using (ShipperADO c = new ShipperADO())
            {
                c.Insertar(shipper);
            }
        }

        public void ActualizarShipper(Shipper shipper)
        {
            using (ShipperADO c = new ShipperADO())
            {
                c.Actualizar(shipper);
            }
        }

        public void BorrarShipper(Shipper shipper)
        {
            using (ShipperADO c = new ShipperADO())
            {
                c.Borrar(shipper);
            }
        }

        // SUPPLIER
        public static List<Supplier> ListarSupplier()
        {
            return SupplierADO.Listar();
        }

        public Supplier BuscarSupplier(int id)
        {
            Supplier sup = new Supplier();

            using (SupplierADO c = new SupplierADO())
            {
                sup = c.Listar(id);
            }

            return sup;
        }

        public void InsertarSupplier(Supplier supplier)
        {
            using (SupplierADO c = new SupplierADO())
            {
                c.Insertar(supplier);
            }
        }

        public void ActualizarSupplier(Supplier supplier)
        {
            using (SupplierADO c = new SupplierADO())
            {
                c.Actualizar(supplier);
            }
        }

        public void BorrarSupplier(Supplier supplier)
        {
            using (SupplierADO c = new SupplierADO())
            {
                c.Borrar(supplier);
            }
        }

    }
}