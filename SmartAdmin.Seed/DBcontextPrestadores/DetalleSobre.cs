using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class DetalleSobre
    {
        public DetalleSobre()
        {
            DetalleSobreLiteral = new HashSet<DetalleSobreLiteral>();
        }

        [Key]
        public int IdDetalleSobre { get; set; }
        public int IdSobre { get; set; }
        public int IdEstado { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaIngresoDetalle { get; set; }
        public int IdTipoCobertura { get; set; }
        public bool Novedad { get; set; }
        public int? IdNovedad { get; set; }
        public int? IdTipoDevolucion { get; set; }
        public int? IdTipoCarta { get; set; }
        public int? IdMotivoDevolucion { get; set; }
        public int? IdMotivoNegativa { get; set; }
        public int? IdMotivoGestion { get; set; }
        public int NumeroPersona { get; set; }
        [Column(TypeName = "decimal(19, 5)")]
        public decimal ValorPresentadoDetalle { get; set; }
        [StringLength(50)]
        public string NumeroSolicitudDetalle { get; set; }
        [StringLength(4000)]
        public string ObservacionesConsultor { get; set; }
        [StringLength(4000)]
        public string ObservacionesGestion { get; set; }
        [StringLength(4000)]
        public string ClausulaDevolucion { get; set; }
        [StringLength(4000)]
        public string ClausulaNegativa { get; set; }
        [StringLength(20)]
        public string NumeroQpra { get; set; }
        public int? IdClausulaDevolucion { get; set; }
        public int? IdClausulaNegativa { get; set; }
        public int? NumeroReclamo { get; set; }
        public int? NumeroAlcance { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaPresentacionReclamo { get; set; }
        public int? EstadoReclamo { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? MontoPresentado { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaLiquidacionReclamo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaPagoReclamo { get; set; }
        [Column(TypeName = "decimal(19, 5)")]
        public decimal? MontoBonificado { get; set; }
        [StringLength(100)]
        public string SecuencialConstitucion { get; set; }
        public bool Migrado { get; set; }
        public int? IdConstitucion { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaCambioEstado { get; set; }

        [ForeignKey("IdConstitucion")]
        [InverseProperty("DetalleSobre")]
        public Constitucion IdConstitucionNavigation { get; set; }
        [InverseProperty("IdDetalleSobreNavigation")]
        public ICollection<DetalleSobreLiteral> DetalleSobreLiteral { get; set; }
    }
}
