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
using VentasEntradas2022.Web.Models.Empleado;
using VentasEntradas2022.Web.Models.FormaDePago;

namespace VentasEntradas2022.Web.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IServicioEmpleados servicioEmpleados;
        private readonly IMapper mapper;

        public EmpleadoController()
        {
            servicioEmpleados = new ServicioEmpleados();
            mapper = AutoMapperConfig.Mapper;
        }

        // GET: FormaDePago
        public ActionResult Index()
        {
            var lista = servicioEmpleados.GetLista();
            return View(lista);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoEditVm empleadoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(empleadoEditVm);
            }

            try
            {
                Empleado empleado = mapper.Map<Empleado>(empleadoEditVm);
                if (servicioEmpleados.Existe(empleado))
                {
                    ModelState.AddModelError(string.Empty, "El empleado ya existe.");
                    return View(empleadoEditVm);
                }

                servicioEmpleados.Guardar(empleado);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(empleadoEditVm);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Empleado empleado = servicioEmpleados.GetEmpleadoPorId(id.Value);
            if (empleado == null)
            {
                return HttpNotFound("El código del empleado no existe.");
            }

            EmpleadoEditVm empleadoEditVm = mapper.Map<EmpleadoEditVm>(empleado);
            return View(empleadoEditVm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoEditVm empleadoEditVm)
        {
            if (!ModelState.IsValid)
            {
                return View(empleadoEditVm);
            }

            Empleado empleado = mapper.Map<Empleado>(empleadoEditVm);
            try
            {
                if (servicioEmpleados.Existe(empleado))
                {
                    ModelState.AddModelError(string.Empty, "Empleado existente.");
                    return View(empleadoEditVm);
                }
                servicioEmpleados.Guardar(empleado);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(empleadoEditVm);
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Empleado empleado = servicioEmpleados.GetEmpleadoPorId(id.Value);
            if (empleado == null)
            {
                return HttpNotFound("El Empleado no existe.");
            }

            EmpleadoEditVm empleadoEditVm = mapper.Map<EmpleadoEditVm>(empleado);
            return View(empleadoEditVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Empleado empleado = servicioEmpleados.GetEmpleadoPorId(id);
            try
            {
                if (servicioEmpleados.EstaRelacionado(empleado))
                {
                    EmpleadoEditVm empleadoEditVm = mapper.Map<EmpleadoEditVm>(empleado);
                    ModelState.AddModelError(string.Empty, "El Empleado está relacionado.");
                    return View(empleadoEditVm);
                }

                servicioEmpleados.Borrar(empleado);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                EmpleadoEditVm empleadoEditVm = mapper.Map<EmpleadoEditVm>(empleado);
                ModelState.AddModelError(string.Empty, e.Message);
                return View(empleadoEditVm);
            }
        }
    }
}