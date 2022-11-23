using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Datos.Repositorios.Facades
{
    public interface IRepositorioFormasDePago
    {
        List<FormaDePago> GetLista();
        FormaDePago GetFormaDePagoPorId(int id);
        void Guardar(FormaDePago formaDePago);
        bool Existe(FormaDePago formaDePago);
        bool EstaRelacionado(FormaDePago formaDePago);
        void Borrar(FormaDePago formaDePago);
    }
}
