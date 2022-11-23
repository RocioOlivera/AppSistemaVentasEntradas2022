using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using VentasEntradas2022.Entidades.Entidades;
using VentasEntradas2022.Servicios.Servicios;
using VentasEntradas2022.Servicios.Servicios.Facades;
using VentasEntradas2022.Web.App_Start;
using VentasEntradas2022.Web.Models.TipoDeDocumento;

namespace VentasEntradas2022.Web.Controllers
{
    public class TipoDeDocumentoController : Controller
    {
        private readonly IServicioTiposDeDocumentos servicio;
        private readonly IMapper mapper;

        public TipoDeDocumentoController()
        {
            servicio = new ServicioTiposDeDocumentos();
            mapper = AutoMapperConfig.Mapper;
        }
        // GET: TipoDeDocumento
        public ActionResult Index()
        {
            var lista = servicio.GetLista();
            return View(lista);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDeDocumentoEditVm tipoDeDocumentoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoDeDocumentoEditVm);
            }

            try
            {
                TipoDeDocumento tipoDeDocumento = mapper.Map<TipoDeDocumento>(tipoDeDocumentoEditVm);
                if (servicio.Existe(tipoDeDocumento))
                {
                    ModelState.AddModelError(string.Empty, "Tipo de Documento existente!!!");
                    return View(tipoDeDocumentoEditVm);
                }

                servicio.Guardar(tipoDeDocumento);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(tipoDeDocumentoEditVm);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TipoDeDocumento tipoDeDocumento = servicio.GetTipoDocumentoPorId(id.Value);
            if (tipoDeDocumento == null)
            {
                return HttpNotFound("Código de Tipo de Documento inexistente.");
            }

            TipoDeDocumentoEditVm tipoDeDocumentoEditVm = mapper.Map<TipoDeDocumentoEditVm>(tipoDeDocumento);
            return View(tipoDeDocumentoEditVm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoDeDocumentoEditVm TipoDeDocumentoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(TipoDeDocumentoEditVm);
            }

            TipoDeDocumento tipoDeDocumento = mapper.Map<TipoDeDocumento>(TipoDeDocumentoEditVm);
            try
            {
                if (servicio.Existe(tipoDeDocumento))
                {
                    ModelState.AddModelError(string.Empty, "Tipo de Documento existente!!!");
                    return View(TipoDeDocumentoEditVm);
                }
                servicio.Guardar(tipoDeDocumento);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(TipoDeDocumentoEditVm);
            }
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            TipoDeDocumento tipoDeDocumento = servicio.GetTipoDocumentoPorId(id.Value);
            if (tipoDeDocumento == null)
            {
                return HttpNotFound("El Tipo de Documento no existe.");
            }

            TipoDeDocumentoEditVm tipoDeDocumentoEditVm = mapper.Map<TipoDeDocumentoEditVm>(tipoDeDocumento);
            return View(tipoDeDocumentoEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            TipoDeDocumento tipoDeDocumento = servicio.GetTipoDocumentoPorId(id);
            try
            {
                if (servicio.EstaRelacionado(tipoDeDocumento))
                {
                    TipoDeDocumentoEditVm tipoDeDocumentoEditVm = mapper.Map<TipoDeDocumentoEditVm>(tipoDeDocumento);
                    ModelState.AddModelError(string.Empty, "El Tipo de Documento está relacionado.");
                    return View(tipoDeDocumentoEditVm);
                }

                servicio.Borrar(tipoDeDocumento);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                TipoDeDocumentoEditVm tipoDeDocumentoEditVm = mapper.Map<TipoDeDocumentoEditVm>(tipoDeDocumento);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(tipoDeDocumentoEditVm);
            }
        }
    }
}