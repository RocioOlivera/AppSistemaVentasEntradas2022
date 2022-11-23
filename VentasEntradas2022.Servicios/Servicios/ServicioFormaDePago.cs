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
    public class ServicioFormaDePago:IServicioFormaDePago
    {
        private readonly IRepositorioFormasDePago repositorio;
        private readonly VentasEntradasDbContext context;

        public ServicioFormaDePago()
        {
            context = new VentasEntradasDbContext();
            repositorio = new RepositorioFormaDePago(context);
        }
        public List<FormaDePago> GetLista()
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

        public FormaDePago GetFormaDePagoPorId(int id)
        {
            try
            {
                return repositorio.GetFormaDePagoPorId(id);
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
                repositorio.Guardar(formaDePago);
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
                return repositorio.Existe(formaDePago);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool EstaRelacionado(FormaDePago formaDePago)
        {
            try
            {
                return repositorio.EstaRelacionado(formaDePago);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(FormaDePago formaDePago)
        {
            try
            {
                repositorio.Borrar(formaDePago);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
