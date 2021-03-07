using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("PAIS")]
    public partial class Pais
    {
        public Pais()
        {
            EstudiosPrestador = new HashSet<EstudiosPrestador>();
        }

        [Key]
        [Column("ID_PAIS", TypeName = "numeric(18, 0)")]
        public decimal IdPais { get; set; }
        [Column("PAI_NOMBRE")]
        [StringLength(500)]
        public string PaiNombre { get; set; }
        [Column("PAI_FECHACREACION", TypeName = "datetime")]
        public DateTime? PaiFechacreacion { get; set; }
        [Column("PAI_CREADOPOR")]
        [StringLength(100)]
        public string PaiCreadopor { get; set; }
        [Column("PAI_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? PaiFechaactualizacion { get; set; }
        [Column("PAI_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string PaiActualizadopor { get; set; }

        [InverseProperty("IdPaisNavigation")]
        public ICollection<EstudiosPrestador> EstudiosPrestador { get; set; }
    }
}
