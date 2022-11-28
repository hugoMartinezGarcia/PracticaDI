///<author>Hugo Martínez</author>

using Entidades;
using Datos;
using System.Linq;
using System.Data;
using System;

namespace Negocio
{
    public class Gestion : IDisposable
    {
        List<Employee> Empleados { get; set; }
        List<Order> Pedidos { get; set; }
        // Flag: Has Dispose already been called?
        bool disposed;
        private const decimal IVA = 21;

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
            // Se obtiene un Order de la bbdd a partir de su id
            order = BuscarOrder(orderId);

            if (order != null)
            {
                // Se obtiene el Employee del pedido si no es null
                order.Employee = order.EmployeeId != null ? BuscarEmployee((int)order.EmployeeId) : null;

                // Se obtiene el Customer del pedido si no es null
                order.Customer = order.CustomerId != null ? BuscarCustomer(order.CustomerId) : null;

                // Se obtiene el Shipper del pedido si no es null
                order.ShipViaNavigation = order.ShipVia != null ? BuscarShipper((int)order.ShipVia) : null;

                // Se obtiene la lista completa de orderDetails de la BBDD
                List<OrderDetail> listaOD = ListarOrderDetail();

                // Se añade al Order el listado de OrderDetails que le corresponden
                foreach (OrderDetail d in listaOD.Where(d => d.OrderId == orderId))
                {
                    order.OrderDetails.Add(d);
                }   

                // Se añade a cada OrderDetail el Producto
                order.OrderDetails
                .ToList()
                .ForEach(o => o.Product = BuscarProduct(o.ProductId));
            }

            return order!;
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


        // Método que devuelve un DataTable con los datos de Products formateados
        public DataTable DataTableProductos(int categorySeleccionada)
        {
            List<Product> productos = new List<Product>();

            // Si se le pasa 0 al método, el datatable devolverá la lista completa de productos
            if (categorySeleccionada == 0)
                productos = ListarProduct();
            else
            {
                productos = ListarProduct().
                Where(p => p.CategoryId == categorySeleccionada).ToList();
            }
            

            DataTable dt = new DataTable();
            dt.Columns.Add("Product Id", typeof(int));
            dt.Columns.Add("Product name", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Quantity per unit", typeof(string));
            dt.Columns.Add("Unit price", typeof(double));
            dt.Columns.Add("Units in stock", typeof(int));
            dt.Columns.Add("Units on order", typeof(int));
            dt.Columns.Add("Reorder level", typeof(int));
            dt.Columns.Add("Discontinued", typeof(bool));

            productos.ForEach(p => dt.Rows.Add(
                p.ProductId, 
                p.ProductName, 
                p.SupplierId != null ? BuscarSupplier((int)p.SupplierId).CompanyName : null,
                p.CategoryId != null ? BuscarCategory((int)p.CategoryId).CategoryName : null, 
                p.QuantityPerUnit, 
                p.UnitPrice, 
                p.UnitsInStock, 
                p.UnitsOnOrder,
                p.ReorderLevel, 
                p.Discontinued));

            return dt;
        }

        // Devuelve un DataTable con los campos de interés de la tabla Customers
        public DataTable DataTableCustomers()
        {
            DataTable dtCustomers = new DataTable();
            // Se crea un DataTable con las columnas de Employee que se mostrarán
            dtCustomers.Columns.Add("Customer Id", typeof(string));
            dtCustomers.Columns.Add("Company name", typeof(string));
            dtCustomers.Columns.Add("Contact name", typeof(string));

            // Se recupera la lista de customers de la BBDD
            List<Customer> customers = new List<Customer>(ListarCustomer());

            // Se rellena el Datatable con los datos de la lista de Employees
            customers.ForEach(c => dtCustomers.Rows.Add(c.CustomerId, c.CompanyName, c.ContactName));

            return dtCustomers;
        }

        // Devuelve un DataTable con los campos de interés de la tabla Orders
        public DataTable DataTableOrders()
        {
            DataTable dtOrders = new DataTable();

            dtOrders.Columns.Add("Order id", typeof(int));
            dtOrders.Columns.Add("Customer id", typeof(string));
            dtOrders.Columns.Add("Employee id", typeof(int));
            dtOrders.Columns.Add("Order date", typeof(DateTime));
            dtOrders.Columns.Add("Required date", typeof(DateTime));
            dtOrders.Columns.Add("Shipped date", typeof(DateTime));

            // Se recupera la lista de orders de la BBDD
            List<Order> orders = new List<Order>(ListarOrder());

            // Se rellena el datatable con los datos de la lista de orders
            orders.ForEach(o => dtOrders.Rows.Add(o.OrderId, o.CustomerId, o.EmployeeId, o.OrderDate, o.RequiredDate, o.ShippedDate));

            return dtOrders;
        }

        public static ResumenFactura ResumenFactura(List<OrderDetail> orderDetails)
        {
            decimal precio = 0;
            orderDetails.ForEach(oD =>
            {
                precio += (oD.UnitPrice * oD.Quantity * (1 - (decimal)oD.Discount)); 
            });
            

            return new ResumenFactura(precio, IVA);
        }

        // Método para crear un Dictionary con los valores que se mostrarán en el gráfico Pedidos Cliente
        public Dictionary<string, int> SeriePedidosCliente()
        {
            Dictionary<string, int> resultado = new Dictionary<string, int>();
            ListarOrder().ForEach(o =>
                {
                    if (o.CustomerId != null)
                    {
                        o.Customer = BuscarCustomer(o.CustomerId);

                        if (!resultado.ContainsKey(o.Customer.CompanyName))
                            resultado.Add(o.Customer.CompanyName, 1);
                        else
                            resultado[o.Customer.CompanyName] = resultado[o.Customer.CompanyName] + 1;
                    }
                });

            return resultado;
        }

        // Método para crear un Dictionary con los valores que se mostrarán en el gráfico Productos por Categoría
        public Dictionary<string, int> SerieProductosPorCategoria()
        {
            Dictionary<string, int> resultado = new Dictionary<string, int>();
            List<Product> products = new List<Product>(ListarProduct());
            int total = 0;

            products.ForEach(p =>
            {
                if (p.CategoryId != null)
                {
                    p.Category = BuscarCategory((int)p.CategoryId);

                   
                    if (!resultado.ContainsKey(p.Category.CategoryName))
                        resultado.Add(p.Category.CategoryName, 1);
                    else
                        resultado[p.Category.CategoryName] = resultado[p.Category.CategoryName] + 1;

                    total++;
                }
            });

            foreach (KeyValuePair<string, int> d in resultado)
            {
                resultado[d.Key] = d.Value * 100 / total;
            }

            return resultado;
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