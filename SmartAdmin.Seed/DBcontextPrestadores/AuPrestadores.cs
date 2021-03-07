using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("au_prestadores")]
    public partial class AuPrestadores
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("operacion")]
        [StringLength(1)]
        public string Operacion { get; set; }
        [Column("host")]
        [StringLength(45)]
        public string Host { get; set; }
        [Column("usuario")]
        [StringLength(45)]
        public string Usuario { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("objeto")]
        [StringLength(80)]
        public string Objeto { get; set; }
    }
}
