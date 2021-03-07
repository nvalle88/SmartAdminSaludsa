#region Using

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SmartAdminSaludsa.Models.ViewModels.Prestadores;

#endregion

namespace SmartAdminSaludsa.Controllers
{
    [Authorize]
    public class PrestadoresController : Controller
    {
        public IConfiguration Configuration { get; }

        public PrestadoresController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #region Pedidos Actuales

        [Authorize(Policy = "Administracion")]
        public IActionResult Beneficios(BuscarBeneficioViewModel buscarBeneficio)
        {
            return View( new BuscarBeneficioViewModel
            {
                CodigoPlan=string.Empty,
                CodigoProducto=string.Empty,
                NumeroConvenio=0,
                VersionPlan=0,
            });
        }

        #endregion
    }
}
