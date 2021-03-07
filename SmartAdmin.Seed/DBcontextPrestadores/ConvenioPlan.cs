using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class ConvenioPlan
    {
        public ConvenioPlan()
        {
            BeneficioConvenio = new HashSet<BeneficioConvenio>();
        }

        [Key]
        public int IdConvenioPlan { get; set; }
        public int NumeroConvenio { get; set; }
        [Required]
        [StringLength(3)]
        public string CodigoProducto { get; set; }
        [Required]
        [StringLength(20)]
        public string CodigoPlan { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaInicioVigencia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaFinVigencia { get; set; }
        public bool EsPromocion { get; set; }
        [StringLength(50)]
        public string NombrePromocion { get; set; }
        public short VersionPlan { get; set; }
        [Column("fec_proceso", TypeName = "datetime")]
        public DateTime? FecProceso { get; set; }
        [Column("fechaUltModificacion", TypeName = "datetime")]
        public DateTime? FechaUltModificacion { get; set; }

        [InverseProperty("IdConvenioPlanNavigation")]
        public ICollection<BeneficioConvenio> BeneficioConvenio { get; set; }
    }
}
