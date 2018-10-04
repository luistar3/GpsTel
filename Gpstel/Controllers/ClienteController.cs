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
        private ObservacionCliente observacionCliente = new ObservacionCliente();
        // GET: Cliente
        public ActionResult Index()
        {
            var lista = objCliente.listarCliente();
            ViewBag.departamento = objDepartamento.listarDepartamento();
            return View(objCliente.listarCliente());
        }

        public JsonResult cargarProvincias(int iddepartamento) {
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

        [HttpPost]
        public ActionResult guardarEditar(Cliente cliente)
        {

            var resultado = new BaseRespuesta();

            try
            {
                cliente.guardarEditar();
                resultado.mensaje = "Exito en el Proceso";
                resultado.ok = "true";
            }
            catch (Exception e)
            {

                resultado.mensaje = e.Message;
                resultado.ok = "false";
            }

            return Json(resultado);
        }


        [HttpPost]
        public JsonResult getCliente(int id) {

            var cliente = new Cliente();
            var dataCliente = new jsonClienteDistrito();
            var clienteJson = new jsonCliente();
            var distritoJson = new jsonDistrito();


            cliente = objCliente.obtenerCliente(id);

            clienteJson.idCliente = Convert.ToString(cliente.idcliente);
            clienteJson.fecha_contrato = parseDate(Convert.ToString(cliente.fecha_contrato));
            clienteJson.estado = cliente.estado;
            clienteJson.nombre = cliente.nombre;
            clienteJson.apellido = cliente.apellido;
            clienteJson.dni_ruc = cliente.dni_ruc;
            clienteJson.telefono = cliente.telefono;
            clienteJson.celular = cliente.celular;
            clienteJson.correo = cliente.correo;
            clienteJson.direccion = cliente.direccion;
            clienteJson.iddistrito =Convert.ToString( cliente.iddistrito);

            distritoJson.iddistrito = Convert.ToInt32(cliente.iddistrito);
            distritoJson.nombre = cliente.Distrito.nombre;
            distritoJson.idprovincia = Convert.ToInt32( cliente.Distrito.idprovincia);

            dataCliente.jsoncliente = clienteJson;
            dataCliente.jsondistrito = distritoJson;


            return Json(dataCliente);
        }
        public static string parseDate(string dataTime)
        {

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString(dataTime);
            return sqlFormattedDate;
        }

        public ActionResult eliminarCliente(int id) {

            try
            {
                objCliente.idcliente = id;
                objCliente.eliminarCliente();
            }
            catch (Exception)
            {

                return Redirect("~/Cliente");
            }
            return Redirect("~/Cliente");
        }

    

    }
}