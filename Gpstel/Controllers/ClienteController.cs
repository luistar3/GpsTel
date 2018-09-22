using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gpstel.Models;

namespace Gpstel.Controllers
{
    public class ClienteController : Controller
    {
        private Cliente objCliente = new Cliente();
        private Distrito objDistrito = new Distrito();
        private Provincia objProvincia = new Provincia();
        private Departamento objDepartamento = new Departamento();
        private jsonProvincia jsonProvincia = new jsonProvincia();
        private jsonDistrito jsonDistrito = new jsonDistrito();
        private ModelGps mdl = new ModelGps();
        // GET: Cliente
        public ActionResult Index()
        {
            var lista = objCliente.listarCliente();
            ViewBag.departamento = objDepartamento.listarDepartamento();
            return View(objCliente.listarCliente());
        }

        public JsonResult cargarProvincias( int iddepartamento) {
            var provincias = new List<jsonProvincia>();
            provincias = mdl.Database.SqlQuery<jsonProvincia>("Select * from Provincia where iddepartamento=@id", new SqlParameter("@id", iddepartamento))
                   .ToList();
           
            return Json(provincias);
        }

        public JsonResult cargarDitritos(int idprovincia)
        {
            var distritos = new List<jsonDistrito>();
            distritos = mdl.Database.SqlQuery<jsonDistrito>("Select * from Distrito where idprovincia=@id", new SqlParameter("@id", idprovincia))
                   .ToList();

            return Json(distritos);
        }
    }
}