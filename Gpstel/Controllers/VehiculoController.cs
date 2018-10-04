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
                return View(vehiculo);
            }
            else
            {
                ViewBag.gps = objGps.obtenerGpsNoRepetido();
                return View(vehiculo.obtenerVehiculo(id));
            }

        }
    }
}