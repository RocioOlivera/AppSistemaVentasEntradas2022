using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Datos;
using VentasEntradas2022.Datos.Repositorios;
using VentasEntradas2022.Datos.Repositorios.Facades;
using VentasEntradas2022.Entidades.Entidades;
using VentasEntradas2022.Servicios.Servicios.Facades;

namespace VentasEntradas2022.Servicios.Servicios
{
    public class ServicioEmpleados:IServicioEmpleados
    {
        private readonly IRepositorioEmpleados repositorio;
        private readonly VentasEntradasDbContext context;

        public ServicioEmpleados()
        {
            context = new VentasEntradasDbContext();
            repositorio = new RepositorioEmpleados(context);
        }
        public List<Empleado> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Empleado GetEmpleadoPorId(int id)
        {
            try
            {
                return repositorio.GetEmpleadoPorId(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Guardar(Empleado empleado)
        {
            try
            {
                repositorio.Guardar(empleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Existe(Empleado empleado)
        {
            try
            {
                return repositorio.Existe(empleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            try
            {
                return repositorio.EstaRelacionado(empleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(Empleado empleado)
        {
            try
            {
                repositorio.Borrar(empleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
