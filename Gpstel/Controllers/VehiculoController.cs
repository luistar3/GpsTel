using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gpstel.Models;

namespace Gpstel.Controllers
{

    
    public class VehiculoController : Controller
    {

        // GET: Vehiculo
<<<<<<< HEAD
=======
        private Cliente objCliente = new Cliente();
>>>>>>> avance 10 de octubre 2018
        private GPS objGps = new GPS();
        private Vehiculo objVihiculo = new Vehiculo();
        public ActionResult Index()
        {
           

            

            return View(objVihiculo.listarVehiculo());
        }

        public ActionResult nuevo(int id = 0) {

            var vehiculo = new Vehiculo();
            var gps = new List<GPS>();

            if (id == 0)
            {
<<<<<<< HEAD
=======
                ViewBag.cliente = objCliente.listarCliente();
                ViewBag.gps = objGps.obtenerGpsNoRepetido();
>>>>>>> avance 10 de octubre 2018
                return View(vehiculo);
            }
            else
            {
<<<<<<< HEAD
=======
                ViewBag.cliente = objCliente.listarCliente();
>>>>>>> avance 10 de octubre 2018
                ViewBag.gps = objGps.obtenerGpsNoRepetido();
                return View(vehiculo.obtenerVehiculo(id));
            }

        }
    }
}