using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VentasEntradas2022.Entidades.Entidades;
using VentasEntradas2022.Web.Models.Empleado;
using VentasEntradas2022.Web.Models.FormaDePago;
using VentasEntradas2022.Web.Models.FormaDeVenta;
using VentasEntradas2022.Web.Models.TipoDeDocumento;

namespace VentasEntradas2022.Web.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadFormaDePagoMapping();
            LoadFormaDeVentaMapping();
            LoadTipoDeDocumentoMapping();
            LoadEmpleadoMapping();
        }

        private void LoadEmpleadoMapping()
        {
            CreateMap<Empleado, EmpleadoEditVm>().ReverseMap();
        }

        private void LoadTipoDeDocumentoMapping()
        {
            CreateMap<TipoDeDocumento, TipoDeDocumentoEditVm>().ReverseMap();
        }

        private void LoadFormaDeVentaMapping()
        {
            CreateMap<FormaDeVenta, FormaDeVentaEditVm>().ReverseMap();
        }

        private void LoadFormaDePagoMapping()
        {
            CreateMap<FormaDePago, FormaDePagoEditVm>().ReverseMap();

        }
    }
}