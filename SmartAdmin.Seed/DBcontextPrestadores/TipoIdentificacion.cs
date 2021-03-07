using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("TIPO_IDENTIFICACION")]
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_TIPOIDENTIFICACION", TypeName = "numeric(18, 0)")]
        public decimal IdTipoidentificacion { get; set; }
        [Column("TID_NOMBRE")]
        [StringLength(500)]
        public string TidNombre { get; set; }
        [Column("TID_ABREVIATURA")]
        [StringLength(5)]
        public string TidAbreviatura { get; set; }
        [Column("TID_FECHACREACION", TypeName = "datetime")]
        public DateTime? TidFechacreacion { get; set; }
        [Column("TID_CREADOPOR")]
        [StringLength(100)]
        public string TidCreadopor { get; set; }
        [Column("TID_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? TidFechaactualizacion { get; set; }
        [Column("TID_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string TidActualizadopor { get; set; }

        [InverseProperty("IdTipoidentificacionNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
