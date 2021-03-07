using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("ACTIVIDAD_ECONOMICA")]
    public partial class ActividadEconomica
    {
        public ActividadEconomica()
        {
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_ACTIVIDADECONOMICA", TypeName = "numeric(18, 0)")]
        public decimal IdActividadeconomica { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("ACT_NOMBRE")]
        [StringLength(500)]
        public string ActNombre { get; set; }
        [Column("ACT_FECHACREACION", TypeName = "datetime")]
        public DateTime? ActFechacreacion { get; set; }
        [Column("ACT_CREADOPOR")]
        [StringLength(100)]
        public string ActCreadopor { get; set; }
        [Column("ACT_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? ActFechaactualizacion { get; set; }
        [Column("ACT_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string ActActualizadopor { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("ActividadEconomica")]
        public Estado IdEstadoNavigation { get; set; }
        [InverseProperty("IdActividadeconomicaNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
