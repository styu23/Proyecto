using Front_GimLife.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using System.Data;
using System.Data.SqlClient;


namespace Front_GimLife.MVC.Controllers
{
    public class ReportesArticulosController : Controller
    {

        private readonly string cadenaSQL;

        public ReportesArticulosController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }

        [HttpGet]
        public JsonResult ReporteArticulos()
        {
            List<ReporteArticulosDeportivos> lista = new List<ReporteArticulosDeportivos>();

            using (var conexion = new SqlConnection(cadenaSQL))
            {
                conexion.Open();
                var cmd = new SqlCommand("sp_reporte_articulos_deportivos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ReporteArticulosDeportivos()
                        {
                            id_producto = Convert.ToInt32(dr["id_producto"]),
                            nombre = Convert.ToString(dr["nombre"]),
                            cantidad = Convert.ToInt32(dr["cantidad"]),
                            precio_compra = Convert.ToInt32(dr["precio_compra"]),
                            precio_venta = Convert.ToInt32(dr["precio_venta"]),
                            proveedor = Convert.ToString(dr["proveedor"])
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