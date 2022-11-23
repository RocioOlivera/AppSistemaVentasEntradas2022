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
    public class ServicioTiposDeDocumentos:IServicioTiposDeDocumentos
    {
        private readonly IRepositorioTiposDeDocumentos repositorio;
        private readonly VentasEntradasDbContext context;

        public ServicioTiposDeDocumentos()
        {
            context = new VentasEntradasDbContext();
            repositorio = new RepositorioTiposDeDocumentos(context);
        }
        public List<TipoDeDocumento> GetLista()
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

        public TipoDeDocumento GetTipoDocumentoPorId(int id)
        {
            try
            {
                return repositorio.GetTipoDocumentoPorId(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Guardar(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                repositorio.Guardar(tipoDeDocumento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Existe(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                return repositorio.Existe(tipoDeDocumento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EstaRelacionado(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                return repositorio.EstaRelacionado(tipoDeDocumento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Borrar(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                repositorio.Borrar(tipoDeDocumento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
