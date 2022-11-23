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
    public class RepositorioFormaDeVenta:IRepositorioFormasDeVenta
    {
        private VentasEntradasDbContext context;

        public RepositorioFormaDeVenta(VentasEntradasDbContext context)
        {
            this.context = context;
        }
        public List<FormaDeVenta> GetLista()
        {
            try
            {
                return context.FormaDeVentas.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public FormaDeVenta GetFormaDeVentaPorId(int id)
        {
            try
            {
                return context.FormaDeVentas.SingleOrDefault(f => f.FormaDeVentaId == id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Guardar(FormaDeVenta formaDeVenta)
        {
            try
            {
                if (formaDeVenta.FormaDeVentaId == 0)
                {
                    context.FormaDeVentas.Add(formaDeVenta);
                }
                else
                {
                    context.Entry(formaDeVenta).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Existe(FormaDeVenta formaDeVenta)
        {
            try
            {
                if (formaDeVenta.FormaDeVentaId == 0)
                {
                    return context.FormaDeVentas.Any(f => f.Descripcion == formaDeVenta.Descripcion);
                }

                return context.FormaDeVentas.Any(f =>
                    f.Descripcion == formaDeVenta.Descripcion && f.FormaDeVentaId == formaDeVenta.FormaDeVentaId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EstaRelacionado(FormaDeVenta formaDeVenta)
        {
            return false;
        }

        public void Borrar(FormaDeVenta formaDeVenta)
        {
            try
            {
                context.Entry(formaDeVenta).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
