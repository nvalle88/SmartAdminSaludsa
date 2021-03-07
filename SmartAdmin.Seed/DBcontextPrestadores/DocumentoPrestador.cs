using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("DOCUMENTO_PRESTADOR")]
    public partial class DocumentoPrestador
    {
        [Key]
        [Column("ID_DOCUMENTOPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdDocumentoprestador { get; set; }
        [Column("ID_TIPODOCUMENTO", TypeName = "numeric(18, 0)")]
        public decimal? IdTipodocumento { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdPrestador { get; set; }
        [Column("DPR_NOMBRE")]
        [StringLength(500)]
        public string DprNombre { get; set; }
        [Column("DPR_CONTENIDO")]
        public byte[] DprContenido { get; set; }
        [Column("DPR_FECHACREACION", TypeName = "datetime")]
        public DateTime? DprFechacreacion { get; set; }
        [Column("DPR_CREADOPOR")]
        [StringLength(100)]
        public string DprCreadopor { get; set; }
        [Column("DPR_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? DprFechaactualizacion { get; set; }
        [Column("DPR_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string DprActualizadopor { get; set; }
        [Column("DPR_TIPOCONTENIDO")]
        [StringLength(200)]
        public string DprTipocontenido { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("DocumentoPrestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPrestador")]
        [InverseProperty("DocumentoPrestador")]
        public Prestador IdPrestadorNavigation { get; set; }
        [ForeignKey("IdTipodocumento")]
        [InverseProperty("DocumentoPrestador")]
        public TipoDocumento IdTipodocumentoNavigation { get; set; }
    }
}
