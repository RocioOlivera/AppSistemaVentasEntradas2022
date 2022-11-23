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
    public class RepositorioTiposDeDocumentos:IRepositorioTiposDeDocumentos
    {
        private VentasEntradasDbContext context;

        public RepositorioTiposDeDocumentos(VentasEntradasDbContext context)
        {
            this.context = context;
        }
        public List<TipoDeDocumento> GetLista()
        {
            try
            {
                return context.TipoDeDocumentos.ToList();
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
                return context.TipoDeDocumentos.SingleOrDefault(t => t.TipoDeDocumentoId == id);
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
                if (tipoDeDocumento.TipoDeDocumentoId == 0)
                {
                    context.TipoDeDocumentos.Add(tipoDeDocumento);
                }
                else
                {
                    context.Entry(tipoDeDocumento).State = EntityState.Modified;
                }

                context.SaveChanges();
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
                if (tipoDeDocumento.TipoDeDocumentoId == 0)
                {
                    return context.TipoDeDocumentos.Any(t => t.TipoDeDoc == tipoDeDocumento.TipoDeDoc);
                }

                return context.TipoDeDocumentos.Any(t => t.TipoDeDoc == tipoDeDocumento.TipoDeDoc
                                                  && t.TipoDeDocumentoId != tipoDeDocumento.TipoDeDocumentoId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EstaRelacionado(TipoDeDocumento tipoDeDocumento)
        {
            return false;
        }

        public void Borrar(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                context.Entry(tipoDeDocumento).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
