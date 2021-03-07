using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("TIPO_CORREO")]
    public partial class TipoCorreo
    {
        public TipoCorreo()
        {
            CorreoPrestador = new HashSet<CorreoPrestador>();
        }

        [Key]
        [Column("ID_TIPOCORREO", TypeName = "numeric(18, 0)")]
        public decimal IdTipocorreo { get; set; }
        [Column("TIC_NOMBRE")]
        [StringLength(500)]
        public string TicNombre { get; set; }
        [Column("TIC_FECHACREACION", TypeName = "datetime")]
        public DateTime? TicFechacreacion { get; set; }
        [Column("TIC_CREADOPOR")]
        [StringLength(100)]
        public string TicCreadopor { get; set; }
        [Column("TIC_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? TicFechaactualizacion { get; set; }
        [Column("TIC_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string TicActualizadopor { get; set; }

        [InverseProperty("IdTipocorreoNavigation")]
        public ICollection<CorreoPrestador> CorreoPrestador { get; set; }
    }
}
