using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Datos.Repositorios.Facades
{
    public interface IRepositorioFormasDeVenta
    {
        List<FormaDeVenta> GetLista();
        FormaDeVenta GetFormaDeVentaPorId(int id);
        void Guardar(FormaDeVenta formaDeVenta);
        bool Existe(FormaDeVenta formaDeVenta);
        bool EstaRelacionado(FormaDeVenta formaDeVenta);
        void Borrar(FormaDeVenta formaDeVenta);
    }
}
