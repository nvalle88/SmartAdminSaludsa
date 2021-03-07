using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("PRESTADOR")]
    public partial class Prestador
    {
        public Prestador()
        {
            CorreoPrestador = new HashSet<CorreoPrestador>();
            DireccionPrestador = new HashSet<DireccionPrestador>();
            DocumentoPrestador = new HashSet<DocumentoPrestador>();
            EspecialidadPrestador = new HashSet<EspecialidadPrestador>();
            EstudiosPrestador = new HashSet<EstudiosPrestador>();
            ProductoPrestador = new HashSet<ProductoPrestador>();
        }

        [Key]
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdPrestador { get; set; }
        [Column("ID_TIPOPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdTipoprestador { get; set; }
        [Column("ID_ACTIVIDADECONOMICA", TypeName = "numeric(18, 0)")]
        public decimal? IdActividadeconomica { get; set; }
        [Column("ID_NIVELATENCION", TypeName = "numeric(18, 0)")]
        public decimal? IdNivelatencion { get; set; }
        [Column("ID_NIVELCOMPLEJIDAD", TypeName = "numeric(18, 0)")]
        public decimal? IdNivelcomplejidad { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("ID_REGION", TypeName = "numeric(18, 0)")]
        public decimal? IdRegion { get; set; }
        [Column("ID_CIUDAD", TypeName = "numeric(18, 0)")]
        public decimal? IdCiudad { get; set; }
        [Column("ID_TIPOIDENTIFICACION", TypeName = "numeric(18, 0)")]
        public decimal? IdTipoidentificacion { get; set; }
        [Required]
        [Column("PRE_IDENTIFICACION")]
        [StringLength(20)]
        public string PreIdentificacion { get; set; }
        [Column("PRE_RAZONSOCIAL")]
        [StringLength(200)]
        public string PreRazonsocial { get; set; }
        [Column("PRE_NOMBRECOMERCIAL")]
        [StringLength(500)]
        public string PreNombrecomercial { get; set; }
        [Column("PRE_FINPERMISOFUNCIONAMIENTO", TypeName = "datetime")]
        public DateTime? PreFinpermisofuncionamiento { get; set; }
        [Column("PRE_INICIOCONVENIO", TypeName = "datetime")]
        public DateTime? PreInicioconvenio { get; set; }
        [Column("PRE_FINCONVENIO", TypeName = "datetime")]
        public DateTime? PreFinconvenio { get; set; }
        [Column("PRE_AFILIADOPRODUCTOSSALUD")]
        public bool PreAfiliadoproductossalud { get; set; }
        [Column("PRE_COSTOCONSULTAPARTICULAR")]
        public decimal? PreCostoconsultaparticular { get; set; }
        [Column("PRE_DESCUENTO")]
        public bool PreDescuento { get; set; }
        [Column("PRE_FECHACREACION", TypeName = "datetime")]
        public DateTime? PreFechacreacion { get; set; }
        [Column("PRE_CREADOPOR")]
        [StringLength(100)]
        public string PreCreadopor { get; set; }
        [Column("PRE_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? PreFechaactualizacion { get; set; }
        [Column("PRE_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string PreActualizadopor { get; set; }
        [Column("ID_PROVINCIA", TypeName = "numeric(18, 0)")]
        public decimal? IdProvincia { get; set; }

        [ForeignKey("IdActividadeconomica")]
        [InverseProperty("Prestador")]
        public ActividadEconomica IdActividadeconomicaNavigation { get; set; }
        [ForeignKey("IdCiudad")]
        [InverseProperty("Prestador")]
        public Ciudad IdCiudadNavigation { get; set; }
        [ForeignKey("IdEstado")]
        [InverseProperty("Prestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdNivelatencion")]
        [InverseProperty("Prestador")]
        public NivelAtencion IdNivelatencionNavigation { get; set; }
        [ForeignKey("IdNivelcomplejidad")]
        [InverseProperty("Prestador")]
        public NivelComplejidad IdNivelcomplejidadNavigation { get; set; }
        [ForeignKey("IdProvincia")]
        [InverseProperty("Prestador")]
        public Provincia IdProvinciaNavigation { get; set; }
        [ForeignKey("IdRegion")]
        [InverseProperty("Prestador")]
        public Region IdRegionNavigation { get; set; }
        [ForeignKey("IdTipoidentificacion")]
        [InverseProperty("Prestador")]
        public TipoIdentificacion IdTipoidentificacionNavigation { get; set; }
        [ForeignKey("IdTipoprestador")]
        [InverseProperty("Prestador")]
        public TipoPrestador IdTipoprestadorNavigation { get; set; }
        [InverseProperty("IdPrestadorNavigation")]
        public ICollection<CorreoPrestador> CorreoPrestador { get; set; }
        [InverseProperty("IdPrestadorNavigation")]
        public ICollection<DireccionPrestador> DireccionPrestador { get; set; }
        [InverseProperty("IdPrestadorNavigation")]
        public ICollection<DocumentoPrestador> DocumentoPrestador { get; set; }
        [InverseProperty("IdPrestadorNavigation")]
        public ICollection<EspecialidadPrestador> EspecialidadPrestador { get; set; }
        [InverseProperty("IdPrestadorNavigation")]
        public ICollection<EstudiosPrestador> EstudiosPrestador { get; set; }
        [InverseProperty("IdPrestadorNavigation")]
        public ICollection<ProductoPrestador> ProductoPrestador { get; set; }
    }
}
