using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("PROVINCIA")]
    public partial class Provincia
    {
        public Provincia()
        {
            Ciudad = new HashSet<Ciudad>();
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_PROVINCIA", TypeName = "numeric(18, 0)")]
        public decimal IdProvincia { get; set; }
        [Column("PRV_NOMBRE")]
        [StringLength(500)]
        public string PrvNombre { get; set; }
        [Column("PRV_FECHACREACION", TypeName = "datetime")]
        public DateTime? PrvFechacreacion { get; set; }
        [Column("PRV_CREADOPOR")]
        [StringLength(100)]
        public string PrvCreadopor { get; set; }
        [Column("PRV_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? PrvFechaactualizacion { get; set; }
        [Column("PRV_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string PrvActualizadopor { get; set; }

        [InverseProperty("IdProvinciaNavigation")]
        public ICollection<Ciudad> Ciudad { get; set; }
        [InverseProperty("IdProvinciaNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
