using Front_GimLife.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using System.Data;
using System.Data.SqlClient;

namespace Front_GimLife.MVC.Controllers
{
    public class ReportesClientesController : Controller
    {
        private readonly string cadenaSQL;

        public ReportesClientesController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }

        [HttpGet]
        public JsonResult ReporteClientes()
        {
            List<ReportesClientes> lista = new List<ReportesClientes>();

            using (var conexion = new SqlConnection(cadenaSQL))
            {
                conexion.Open();
                var cmd = new SqlCommand("sp_reporte_clientes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ReportesClientes()
                        {
                            id_dni = Convert.ToInt32(dr["id_dni"]),
                            cliente = Convert.ToString(dr["cliente"]),
                            dni = Convert.ToInt32(dr["dni"]),
                            fecha_ini = Convert.ToString(dr["fecha_ini"]),
                            fecha_fin = Convert.ToString(dr["fecha_fin"]),
                            ocupacion = Convert.ToString(dr["ocupacion"]),
                            planes = Convert.ToString(dr["planes"]),
                            promocion = Convert.ToString(dr["promocion"])
                        });
                    }
                }
            }

            return Json(new { data = lista });
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
