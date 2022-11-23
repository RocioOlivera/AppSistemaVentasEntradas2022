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
using VentasEntradas2022.Web.Models.FormaDeVenta;

namespace VentasEntradas2022.Web.Controllers
{
    public class FormaDeVentaController : Controller
    {
        private readonly IServicioFormaDeVenta servicio;
        private readonly IMapper mapper;

        public FormaDeVentaController()
        {
            servicio = new ServicioFormaDeVenta();
            mapper = AutoMapperConfig.Mapper;
        }
        // GET: FormaDeVenta
        public ActionResult Index()
        {
            var lista = servicio.GetLista();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormaDeVentaEditVm formaDeVentaVm)
        {
            if (!ModelState.IsValid)
            {
                return View(formaDeVentaVm);
            }

            try
            {
                FormaDeVenta formaDeVenta = mapper.Map<FormaDeVenta>(formaDeVentaVm);
                if (servicio.Existe(formaDeVenta))
                {
                    ModelState.AddModelError(string.Empty, "La forma de venta ya existe.");
                    return View(formaDeVentaVm);
                }

                servicio.Guardar(formaDeVenta);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(formaDeVentaVm);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            FormaDeVenta formaDeVenta = servicio.GetFormaDeVentaPorId(id.Value);
            if (formaDeVenta == null)
            {
                return HttpNotFound("El código de forma de venta no existe.");
            }

            FormaDeVentaEditVm formaDeventaVm = mapper.Map<FormaDeVentaEditVm>(formaDeVenta);
            return View(formaDeventaVm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormaDeVentaEditVm formaDeVentaEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(formaDeVentaEditVm);
            }

            FormaDeVenta formaDeVenta = mapper.Map<FormaDeVenta>(formaDeVentaEditVm);
            try
            {
                if (servicio.Existe(formaDeVenta))
                {
                    ModelState.AddModelError(string.Empty, "Forma de Venta existente.");
                    return View(formaDeVentaEditVm);
                }
                servicio.Guardar(formaDeVenta);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(formaDeVentaEditVm);
            }
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            FormaDeVenta formaDeVenta = servicio.GetFormaDeVentaPorId(id.Value);
            if (formaDeVenta == null)
            {
                return HttpNotFound("La Forma de Venta no existe.");
            }

            FormaDeVentaEditVm formaDeVentaEditVm = mapper.Map<FormaDeVentaEditVm>(formaDeVenta);
            return View(formaDeVentaEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            FormaDeVenta formaDeVenta = servicio.GetFormaDeVentaPorId(id);
            try
            {
                if (servicio.EstaRelacionado(formaDeVenta))
                {
                    FormaDeVentaEditVm formaDeVentaEditVm = mapper.Map<FormaDeVentaEditVm>(formaDeVenta);
                    ModelState.AddModelError(string.Empty, "La Forma de Venta está relacionada.");
                    return View(formaDeVentaEditVm);
                }

                servicio.Borrar(formaDeVenta);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                FormaDeVentaEditVm formaDeVentaEditVm = mapper.Map<FormaDeVentaEditVm>(formaDeVenta);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(formaDeVentaEditVm);
            }
        }
    }
}

