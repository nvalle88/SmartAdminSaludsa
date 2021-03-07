using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("TIPO_DOCUMENTO")]
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            DocumentoPrestador = new HashSet<DocumentoPrestador>();
        }

        [Key]
        [Column("ID_TIPODOCUMENTO", TypeName = "numeric(18, 0)")]
        public decimal IdTipodocumento { get; set; }
        [Column("TDC_NOMBRE")]
        [StringLength(500)]
        public string TdcNombre { get; set; }
        [Column("TDC_CODIGO")]
        [StringLength(10)]
        public string TdcCodigo { get; set; }
        [Column("TDC_FECHACREACION", TypeName = "datetime")]
        public DateTime? TdcFechacreacion { get; set; }
        [Column("TDC_CREADOPOR")]
        [StringLength(100)]
        public string TdcCreadopor { get; set; }
        [Column("TDC_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? TdcFechaactualizacion { get; set; }
        [Column("TDC_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string TdcActualizadopor { get; set; }

        [InverseProperty("IdTipodocumentoNavigation")]
        public ICollection<DocumentoPrestador> DocumentoPrestador { get; set; }
    }
}
