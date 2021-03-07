#region Using

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Saludsa.UtilidadesRest;
using SistemaPedidos.Utilidades;
using SmartAdmin.Seed.Models.DTO;
using SmartAdminSaludsa.DBcontextPrestadores;
using SmartAdminSaludsa.Extensores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace SmartAdminSaludsa.Controllers
{
    [Authorize]
    public class PrestadoresController : Controller
    {
        public IConfiguration Configuration { get; }
        private readonly PrestadoresContext db;

        public PrestadoresController(IConfiguration configuration, PrestadoresContext context)
        {
            Configuration = configuration;
            this.db = context;
        }

        #region Pedidos Actuales

        [Authorize(Policy = "Administracion")]
        public IActionResult Beneficios()
        {
            Log.WriteLog("", TypeError.Info, $"", Proceso: "Prestadores-Beneficios", usuario: User.Identity.Name);
            return View();
        }


        [Authorize(Policy = "Administracion")]
        public async Task<JsonResult>  ObtenerBeneficios(int? numeroConvenio, 
            string codigoProducto, 
            string codigoPlan, 
            int? versionPlan, int numeroPagina=1, int cantidadRegistros=50)
        {

            var idTRansaccion= Log.ObtenerIdTransaccion();
            var metodo = "Prestadores-ObtenerBeneficios";
            try
            {

                Log.WriteLog(idTRansaccion, 
                    TypeError.Info, 
                    $"parametros: Convenio-{numeroConvenio}, Prod-{codigoProducto}, Plan-{codigoPlan}, version-{versionPlan}",
                    Proceso: metodo, usuario: User.Identity.Name);

                var query = db.ConvenioPlan.AsQueryable();

                if (numeroConvenio.HasValue)
                    query = query.Where(x => x.NumeroConvenio== numeroConvenio.Value);

                if (!string.IsNullOrWhiteSpace(codigoProducto))
                    query = query.Where(x => x.CodigoProducto.Equals(codigoProducto.Trim(), StringComparison.InvariantCultureIgnoreCase));

                if (!string.IsNullOrWhiteSpace(codigoPlan))
                    query = query.Where(x => x.CodigoPlan.Equals(codigoPlan.Trim(), StringComparison.InvariantCultureIgnoreCase));

                if (versionPlan.HasValue)
                    query = query.Where(x => x.VersionPlan==versionPlan.Value);


                var resultado =  query.PaginateResult(numeroPagina,cantidadRegistros);

                Log.WriteLog(idTRansaccion, TypeError.Info, $"{Respuesta.OK}-Cantidad registros: {resultado.TotalRegistros}", Proceso: metodo);

                return new JsonResult(new RespuestaGenericaPaginada
                {
                    Estado = Respuesta.OK,
                    Resultado = resultado.Entidades.IsNull() ? new List<ConvenioPlan>() : resultado.Entidades,
                    TotalRegistros = resultado.Entidades.IsNull() ? 0 : resultado.TotalRegistros,
                    Mensaje = resultado.TotalRegistros == 0 ? "No existen " : string.Empty ,

                });

            }
            catch (Exception ex)
            {
                Log.WriteLog(idTRansaccion, TypeError.Error, $"Detalle error:{ex.Serializar()}",Proceso: metodo);

                return new JsonResult(new RespuestaGenericaPaginada
                {
                    Estado = Respuesta.Error,
                    TotalRegistros=0,
                    Mensaje = ex.Message,
                    Resultado = null,
                });
            }

        }
        #endregion
    }
}
