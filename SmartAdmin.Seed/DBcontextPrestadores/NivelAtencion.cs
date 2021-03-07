using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("NIVEL_ATENCION")]
    public partial class NivelAtencion
    {
        public NivelAtencion()
        {
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_NIVELATENCION", TypeName = "numeric(18, 0)")]
        public decimal IdNivelatencion { get; set; }
        [Column("NAT_NOMBRE")]
        [StringLength(500)]
        public string NatNombre { get; set; }
        [Column("NAT_FECHACREACION", TypeName = "datetime")]
        public DateTime? NatFechacreacion { get; set; }
        [Column("NAT_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? NatFechaactualizacion { get; set; }
        [Column("NAT_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string NatActualizadopor { get; set; }
        [Column("NAT_CREADOPOR")]
        [StringLength(100)]
        public string NatCreadopor { get; set; }

        [InverseProperty("IdNivelatencionNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
