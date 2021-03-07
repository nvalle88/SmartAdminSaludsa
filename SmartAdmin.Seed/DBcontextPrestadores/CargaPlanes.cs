using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class CargaPlanes
    {
        [Key]
        public int IdCargaPlanes { get; set; }
        public long NumeroConvenio { get; set; }
        [Required]
        [StringLength(3)]
        public string CodigoProducto { get; set; }
        [Required]
        [StringLength(30)]
        public string CodigoPlan { get; set; }
        public short Version { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaFin { get; set; }
        public bool EsPromocion { get; set; }
        [StringLength(50)]
        public string NombrePromocion { get; set; }
        public double? A002 { get; set; }
        public double? A003 { get; set; }
        public double? A004 { get; set; }
        public double? A005 { get; set; }
        public double? A010 { get; set; }
        public double? A011 { get; set; }
        [Column("AH01")]
        public double? Ah01 { get; set; }
        [Column("AH02")]
        public double? Ah02 { get; set; }
        [Column("AH03")]
        public double? Ah03 { get; set; }
    }
}
