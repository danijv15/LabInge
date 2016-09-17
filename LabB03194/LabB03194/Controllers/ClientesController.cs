using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabB03194.Models;

namespace LabB03194.Controllers
{
    public class ClientesController : Controller
    {

        B03194Entities baseDatos = new B03194Entities();
        // GET: Clientes
        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaClientes = baseDatos.Cliente.ToList();
            modelo.listaTelefonos = baseDatos.Telefono.ToList();
            modelo.listaCuentas = baseDatos.Cuenta.ToList();
            return View(modelo);
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                baseDatos.Cliente.Add(modelo.modeloCliente);
                baseDatos.SaveChanges();

                if (modelo.modeloTelefono1.numero != null) {

                    modelo.modeloTelefono1.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.Telefono.Add(modelo.modeloTelefono1);
                }

                if (modelo.modeloTelefono2.numero != null) {

                    modelo.modeloTelefono2.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.Telefono.Add(modelo.modeloTelefono2);
                }

                if (modelo.modeloCuenta1.numero != null)
                {

                    modelo.modeloCuenta1.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.Cuenta.Add(modelo.modeloCuenta1);
                }

                if (modelo.modeloCuenta2.numero != null)
                {

                    modelo.modeloCuenta2.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.Cuenta.Add(modelo.modeloCuenta2);
                }

                if (modelo.modeloCuenta3.numero != null)
                {

                    modelo.modeloCuenta3.cedulaCliente = modelo.modeloCliente.cedula;
                    baseDatos.Cuenta.Add(modelo.modeloCuenta3);
                }

                baseDatos.SaveChanges();
                return RedirectToAction("Index");
            }

            else {

                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }
    }
}