using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Servicios.Servicios.Facades
{
    public interface IServicioTiposDeDocumentos
    {
        List<TipoDeDocumento> GetLista();
        TipoDeDocumento GetTipoDocumentoPorId(int id);
        void Guardar(TipoDeDocumento tipoDeDocumento);
        bool Existe(TipoDeDocumento tipoDeDocumento);
        bool EstaRelacionado(TipoDeDocumento tipoDeDocumento);
        void Borrar(TipoDeDocumento tipoDeDocumento);
    }
}
