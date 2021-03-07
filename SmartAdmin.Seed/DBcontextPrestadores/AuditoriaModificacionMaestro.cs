using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class AuditoriaModificacionMaestro
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(25)]
        public string Programa { get; set; }
        [Required]
        [StringLength(500)]
        public string Ruta { get; set; }
        [StringLength(3000)]
        public string Identidad { get; set; }
        [Required]
        [StringLength(8000)]
        public string EstadoInicial { get; set; }
    }
}
