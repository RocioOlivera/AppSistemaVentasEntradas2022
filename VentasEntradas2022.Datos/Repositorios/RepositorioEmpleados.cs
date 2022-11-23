using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Datos.Repositorios.Facades;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Datos.Repositorios
{
    public class RepositorioEmpleados:IRepositorioEmpleados
    {
        private readonly VentasEntradasDbContext context;

        public RepositorioEmpleados(VentasEntradasDbContext context)
        {
            this.context = context;
        }
        public List<Empleado> GetLista()
        {
            try
            {
                return context.Empleados.OrderBy(e => e.ApellidoYNombres).ToList();
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
                return context.Empleados.SingleOrDefault(e => e.EmpleadoId == id);
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
                if (empleado.EmpleadoId==0)
                {
                    context.Empleados.Add(empleado);
                }
                else
                {
                    context.Entry(empleado).State = EntityState.Modified;
                }

                context.SaveChanges();
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
                if (empleado.EmpleadoId == 0)
                {
                    return context.Empleados.Any(e => e.NroDocumento == empleado.NroDocumento);
                }

                return context.Empleados.Any(e => e.NroDocumento == empleado.NroDocumento
                                               && e.EmpleadoId != empleado.EmpleadoId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            return false;
        }

        public void Borrar(Empleado empleado)
        {
            try
            {
                context.Entry(empleado).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
