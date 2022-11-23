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
    public class ServicioFormaDeVenta:IServicioFormaDeVenta
    {
        private readonly IRepositorioFormasDeVenta repositorio;
        private readonly VentasEntradasDbContext context;

        public ServicioFormaDeVenta()
        {
            context = new VentasEntradasDbContext();
            repositorio = new RepositorioFormaDeVenta(context);
        }
        public List<FormaDeVenta> GetLista()
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

        public FormaDeVenta GetFormaDeVentaPorId(int id)
        {
            try
            {
                return repositorio.GetFormaDeVentaPorId(id);
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
                repositorio.Guardar(formaDeVenta);
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
                return repositorio.Existe(formaDeVenta);
            }
            catch (Exception e)
            {
  
                throw e;
            }
        }

        public bool EstaRelacionado(FormaDeVenta formaDeVenta)
        {
            try
            {
                return repositorio.EstaRelacionado(formaDeVenta);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(FormaDeVenta formaDeVenta)
        {
            try
            {
                repositorio.Borrar(formaDeVenta);
            }
            catch (Exception e)
            { 
                throw e;
            }
        }
    }
}
