using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("ESPECIALIDAD_PRESTADOR")]
    public partial class EspecialidadPrestador
    {
        [Key]
        [Column("ID_ESPECIALIDADPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdEspecialidadprestador { get; set; }
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdPrestador { get; set; }
        [Column("ID_SUBESPECIALIDAD")]
        [StringLength(10)]
        public string IdSubespecialidad { get; set; }
        [Column("EPP_PVP")]
        public decimal? EppPvp { get; set; }
        [Column("EPP_PRECIOSALUD")]
        public decimal? EppPreciosalud { get; set; }
        [Column("EPP_ASUMESALUD")]
        public decimal? EppAsumesalud { get; set; }
        [Column("EPP_PAGACLIENTE")]
        public decimal? EppPagacliente { get; set; }
        [Column("EPP_FECHACREACION", TypeName = "datetime")]
        public DateTime? EppFechacreacion { get; set; }
        [Column("EPP_CREADOPOR")]
        [StringLength(100)]
        public string EppCreadopor { get; set; }
        [Column("EPP_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? EppFechaactualizacion { get; set; }
        [Column("EPP_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string EppActualizadopor { get; set; }
        [Column("ID_ESPECIALIDAD")]
        [StringLength(10)]
        public string IdEspecialidad { get; set; }
        [Column("EPP_DESCUENTO", TypeName = "numeric(18, 2)")]
        public decimal? EppDescuento { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("EPP_PORCENTAJE")]
        public bool EppPorcentaje { get; set; }
        [Column("EPP_ESPECIALIDAD")]
        [StringLength(100)]
        public string EppEspecialidad { get; set; }
        [Column("EPP_SUBESPECIALIDAD")]
        [StringLength(100)]
        public string EppSubespecialidad { get; set; }
        [Column("EPP_MEDICO")]
        [StringLength(200)]
        public string EppMedico { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("EspecialidadPrestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPrestador")]
        [InverseProperty("EspecialidadPrestador")]
        public Prestador IdPrestadorNavigation { get; set; }
    }
}
