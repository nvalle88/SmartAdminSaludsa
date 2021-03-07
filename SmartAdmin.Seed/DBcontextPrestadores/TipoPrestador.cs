using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("TIPO_PRESTADOR")]
    public partial class TipoPrestador
    {
        public TipoPrestador()
        {
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_TIPOPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdTipoprestador { get; set; }
        [Column("TPR_NOMBRE")]
        [StringLength(500)]
        public string TprNombre { get; set; }
        [Column("TPR_FECHACREACION", TypeName = "datetime")]
        public DateTime? TprFechacreacion { get; set; }
        [Column("TPR_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? TprFechaactualizacion { get; set; }
        [Column("TPR_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string TprActualizadopor { get; set; }
        [Column("TPR_CREADOPOR")]
        [StringLength(100)]
        public string TprCreadopor { get; set; }

        [InverseProperty("IdTipoprestadorNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
