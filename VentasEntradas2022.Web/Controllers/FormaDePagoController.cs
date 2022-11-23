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
using VentasEntradas2022.Web.Models.FormaDePago;

namespace VentasEntradas2022.Web.Controllers
{
    public class FormaDePagoController : Controller
    {
        private readonly IServicioFormaDePago servicio;
        private readonly IMapper mapper;

        public FormaDePagoController()
        {
            servicio = new ServicioFormaDePago();
            mapper = AutoMapperConfig.Mapper;
        }
        // GET: FormaDePago
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
        public ActionResult Create(FormaDePagoEditVm formaDePagoVm)
        {
            if (!ModelState.IsValid)
            {
                return View(formaDePagoVm);
            }

            try
            {
                FormaDePago formaDePago = mapper.Map<FormaDePago>(formaDePagoVm);
                if (servicio.Existe(formaDePago))
                {
                    ModelState.AddModelError(string.Empty, "La forma de pago ya existe.");
                    return View(formaDePagoVm);
                }

                servicio.Guardar(formaDePago);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(formaDePagoVm);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            FormaDePago formaDePago = servicio.GetFormaDePagoPorId(id.Value);
            if (formaDePago == null)
            {
                return HttpNotFound("El código de forma de pago no existe.");
            }

            FormaDePagoEditVm formaDePagoVm = mapper.Map<FormaDePagoEditVm>(formaDePago);
            return View(formaDePagoVm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormaDePagoEditVm formaDePagoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(formaDePagoEditVm);
            }

            FormaDePago formaDePago = mapper.Map<FormaDePago>(formaDePagoEditVm);
            try
            {
                if (servicio.Existe(formaDePago))
                {
                    ModelState.AddModelError(string.Empty, "Forma de Pago existente.");
                    return View(formaDePagoEditVm);
                }
                servicio.Guardar(formaDePago);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(formaDePagoEditVm);
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            FormaDePago formaDePago = servicio.GetFormaDePagoPorId(id.Value);
            if (formaDePago == null)
            {
                return HttpNotFound("La Forma de Pago no existe.");
            }

            FormaDePagoEditVm formaDePagoEditVm = mapper.Map<FormaDePagoEditVm>(formaDePago);
            return View(formaDePagoEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            FormaDePago formaDePago = servicio.GetFormaDePagoPorId(id);
            try
            {
                if (servicio.EstaRelacionado(formaDePago))
                {
                    FormaDePagoEditVm formaDePagoEditVm = mapper.Map<FormaDePagoEditVm>(formaDePago);
                    ModelState.AddModelError(string.Empty, "La Forma de Pago está relacionada.");
                    return View(formaDePagoEditVm);
                }

                servicio.Borrar(formaDePago);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                FormaDePagoEditVm formaDePagoEditVm = mapper.Map<FormaDePagoEditVm>(formaDePago);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(formaDePagoEditVm);
            }
        }
    }
}