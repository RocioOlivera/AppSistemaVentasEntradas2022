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
    public class RepositorioFormaDePago:IRepositorioFormasDePago
    {
        private VentasEntradasDbContext context;

        public RepositorioFormaDePago(VentasEntradasDbContext context)
        {
            this.context = context;
        }
        public List<FormaDePago> GetLista()
        {
            try
            {
                return context.FormaDePagos.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public FormaDePago GetFormaDePagoPorId(int id)
        {
            try
            {
                return context.FormaDePagos.SingleOrDefault(f => f.FormaDePagoId == id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Guardar(FormaDePago formaDePago)
        {
            try
            {
                if (formaDePago.FormaDePagoId==0)
                {
                    context.FormaDePagos.Add(formaDePago);
                }
                else
                {
                    context.Entry(formaDePago).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Existe(FormaDePago formaDePago)
        {
            try
            {
                if (formaDePago.FormaDePagoId==0)
                {
                    return context.FormaDePagos.Any(f => f.Descripcion == formaDePago.Descripcion);
                }

                return context.FormaDePagos.Any(f =>
                    f.Descripcion == formaDePago.Descripcion && f.FormaDePagoId == formaDePago.FormaDePagoId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EstaRelacionado(FormaDePago formaDePago)
        {
            return false;
        }
        public void Borrar(FormaDePago formaDePago)
        {
            try
            {
                context.Entry(formaDePago).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
