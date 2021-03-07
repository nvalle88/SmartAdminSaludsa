using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("REGION")]
    public partial class Region
    {
        public Region()
        {
            Prestador = new HashSet<Prestador>();
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        [Column("ID_REGION", TypeName = "numeric(18, 0)")]
        public decimal IdRegion { get; set; }
        [Column("REG_NOMBRE")]
        [StringLength(500)]
        public string RegNombre { get; set; }
        [Column("REG_FECHACREACION", TypeName = "datetime")]
        public DateTime? RegFechacreacion { get; set; }
        [Column("REG_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? RegFechaactualizacion { get; set; }
        [Column("REG_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string RegActualizadopor { get; set; }
        [Column("REG_CREADOPOR")]
        [StringLength(100)]
        public string RegCreadopor { get; set; }

        [InverseProperty("IdRegionNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
        [InverseProperty("IdRegionNavigation")]
        public ICollection<Usuario> Usuario { get; set; }
    }
}
