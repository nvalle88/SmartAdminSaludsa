using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("CORREO_PRESTADOR")]
    public partial class CorreoPrestador
    {
        [Key]
        [Column("ID_PRESTADORCORREO", TypeName = "numeric(18, 0)")]
        public decimal IdPrestadorcorreo { get; set; }
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdPrestador { get; set; }
        [Column("ID_TIPOCORREO", TypeName = "numeric(18, 0)")]
        public decimal? IdTipocorreo { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("CPR_CORREO")]
        [StringLength(200)]
        public string CprCorreo { get; set; }
        [Column("CPR_FECHACREACION", TypeName = "datetime")]
        public DateTime? CprFechacreacion { get; set; }
        [Column("CPR_CREADOPOR")]
        [StringLength(100)]
        public string CprCreadopor { get; set; }
        [Column("CPR_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? CprFechaactualizacion { get; set; }
        [Column("CPR_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string CprActualizadopor { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("CorreoPrestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPrestador")]
        [InverseProperty("CorreoPrestador")]
        public Prestador IdPrestadorNavigation { get; set; }
        [ForeignKey("IdTipocorreo")]
        [InverseProperty("CorreoPrestador")]
        public TipoCorreo IdTipocorreoNavigation { get; set; }
    }
}
