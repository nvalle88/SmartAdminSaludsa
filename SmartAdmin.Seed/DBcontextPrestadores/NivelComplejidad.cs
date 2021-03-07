using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("NIVEL_COMPLEJIDAD")]
    public partial class NivelComplejidad
    {
        public NivelComplejidad()
        {
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_NIVELCOMPLEJIDAD", TypeName = "numeric(18, 0)")]
        public decimal IdNivelcomplejidad { get; set; }
        [Column("NCO_NOMBRE")]
        [StringLength(500)]
        public string NcoNombre { get; set; }
        [Column("NCO_FECHACREACION", TypeName = "datetime")]
        public DateTime? NcoFechacreacion { get; set; }
        [Column("NCO_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? NcoFechaactualizacion { get; set; }
        [Column("NCO_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string NcoActualizadopor { get; set; }
        [Column("NCO_CREADOPOR")]
        [StringLength(100)]
        public string NcoCreadopor { get; set; }

        [InverseProperty("IdNivelcomplejidadNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
