///<author>Hugo Martínez</author>
using Entidades;

namespace Presentacion
{
    // Interfaz para enviar el empleado desde el Form Acceso hasta el Form Principal
    public interface IForm
    {
        void DefinirEmpleado(Employee empleado);
    }
}