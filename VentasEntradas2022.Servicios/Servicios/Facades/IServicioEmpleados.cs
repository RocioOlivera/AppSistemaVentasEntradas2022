using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Servicios.Servicios.Facades
{
    public interface IServicioEmpleados
    {
        List<Empleado> GetLista();
        Empleado GetEmpleadoPorId(int id);
        void Guardar(Empleado empleado);
        bool Existe(Empleado empleado);
        bool EstaRelacionado(Empleado empleado);
        void Borrar(Empleado empleado);
    }
}
