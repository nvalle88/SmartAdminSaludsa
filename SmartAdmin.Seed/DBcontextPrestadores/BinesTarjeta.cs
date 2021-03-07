using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class BinesTarjeta
    {
        [StringLength(15)]
        public string Bines { get; set; }
        [StringLength(50)]
        public string Entidad { get; set; }
        [StringLength(50)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(50)]
        public string Codificacion { get; set; }
    }
}
