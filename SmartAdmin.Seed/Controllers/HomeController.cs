#region Using

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SistemaPedidos.Utilidades;
using SistemaPedidos.Utils;

#endregion

namespace SmartAdminSaludsa.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #region Pedidos Actuales

        [Authorize(Policy = "Administracion")]
        public IActionResult Index()
        {
            this.TempData["Mensaje"] = $"{Mensaje.MensajeSatisfactorio}| Bienvenido {User.Identity.Name}";
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> PedidosActuales()
        {
            var sesionExpirada = false;
            try
            {
                var usuario = HttpContext.Session.GetString("IdEstablecimiento");
                LoggerBase.WriteLog("Home-PedidosActuales-POST", "Usuario", "IdEstablecimiento", usuario, TypeError.Info);
                if (string.IsNullOrEmpty(usuario))
                {
                    sesionExpirada = true;
                    throw new Exception("IdEstablecimiento no encontrado");
                }
               
                return Json(new
                {
                  
                });
            }
            catch (Exception ex)
            {
                LoggerBase.WriteLog("Home-PedidosActuales", "Usuario", "PedidosActuales", ex.Message, TypeError.Error);
                return Json(new
                {
                    estado = false,
                    sesionExpirada,
                    lista = string.Empty,
                    mensaje = ex.Message,
                });
            }
        }

        #endregion
    }
}
