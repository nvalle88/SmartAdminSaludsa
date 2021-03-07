#region Using

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartAdmin.Seed.Models.DTO;
using SmartAdminSaludsa.DBcontextPrestadores;
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
            return View();
        }


        [Authorize(Policy = "Administracion")]
        public async Task<JsonResult>  ObtenerBeneficios(int numeroConvenio, 
            string codigoProducto, 
            string codigoPlan, 
            int versionPlan)
        {
            try
            {
                var query = db.ConvenioPlan.AsQueryable();

                if (numeroConvenio > 0)
                    query = query.Where(x => x.NumeroConvenio.Equals(numeroConvenio));

                if (!string.IsNullOrWhiteSpace(codigoProducto))
                    query = query.Where(x => x.CodigoProducto.Equals(codigoProducto, StringComparison.InvariantCultureIgnoreCase));

                if (!string.IsNullOrWhiteSpace(codigoPlan))
                    query = query.Where(x => x.CodigoPlan.Equals(codigoPlan, StringComparison.InvariantCultureIgnoreCase));

                if (versionPlan > 0)
                    query = query.Where(x => x.VersionPlan.Equals(versionPlan));

                var resultado = await query.ToListAsync();


                return new JsonResult(new RespuestaGenerica
                {
                    Estado = Respuesta.OK,
                    Mensaje = string.Empty,
                    Resultado = resultado,
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new RespuestaGenerica
                {
                    Estado = Respuesta.Error,
                    Mensaje = ex.Message,
                    Resultado = null,
                });
            }

        }
        #endregion
    }
}
