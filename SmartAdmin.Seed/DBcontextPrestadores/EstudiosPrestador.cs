using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("ESTUDIOS_PRESTADOR")]
    public partial class EstudiosPrestador
    {
        [Key]
        [Column("ID_ESTUDIOPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdEstudioprestador { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdPrestador { get; set; }
        [Column("ESP_UNIVERSIDAD")]
        [StringLength(500)]
        public string EspUniversidad { get; set; }
        [Column("ESP_FECHAGRADUACION", TypeName = "datetime")]
        public DateTime? EspFechagraduacion { get; set; }
        [Column("ESP_NOMBRE")]
        [StringLength(500)]
        public string EspNombre { get; set; }
        [Column("ESP_FECHACREACION", TypeName = "datetime")]
        public DateTime? EspFechacreacion { get; set; }
        [Column("ESP_CREADOPOR")]
        [StringLength(100)]
        public string EspCreadopor { get; set; }
        [Column("ESP_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? EspFechaactualizacion { get; set; }
        [Column("ESP_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string EspActualizadopor { get; set; }
        [Column("ID_PAIS", TypeName = "numeric(18, 0)")]
        public decimal? IdPais { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("EstudiosPrestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPais")]
        [InverseProperty("EstudiosPrestador")]
        public Pais IdPaisNavigation { get; set; }
        [ForeignKey("IdPrestador")]
        [InverseProperty("EstudiosPrestador")]
        public Prestador IdPrestadorNavigation { get; set; }
    }
}
