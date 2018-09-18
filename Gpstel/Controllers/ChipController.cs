using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gpstel.Models;


namespace Gpstel.Controllers
{
    public class ChipController : Controller
    {
        private BaseRespuesta resultado = new BaseRespuesta();
        private CHIP objChip = new CHIP();

        // GET: Chip
        public ActionResult Index()
        {


            return View(objChip.listarchip());
        }
        [HttpPost]
        public ActionResult guardarEditar(CHIP chip) {

            var resultado = new BaseRespuesta();

            try
            {
                chip.guardarEditar();

                resultado.mensaje = "chip creado correctamente";
                resultado.ok = "tru";
            }
            catch (Exception e)
            {
                resultado.mensaje = e.Message;
                resultado.ok = "false";

            }

            return Json(resultado);

        }
        [HttpPost]
        public JsonResult getChip(int id)
        {
            var chip = new CHIP();
            chip = objChip.obtenerChip(id);

            return Json(chip);
        }

        
        public ActionResult eliminarChip(int id) {

           

            objChip.idchip = id;
            objChip.eliminarChip();

            return Redirect("~/Chip");
        }
    }
}