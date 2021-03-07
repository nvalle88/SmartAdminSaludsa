#region Using

using SmartAdminSaludsa.Utils;
using System.ComponentModel.DataAnnotations;

#endregion

namespace SmartAdminSaludsa.Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage =Validaciones.Requerido)]
        [EmailAddress(ErrorMessage =Validaciones.FormatoCorreo)]
        [Display(Name ="Correo elctr�nico")]
        public string Email { get; set; }
    }
}
