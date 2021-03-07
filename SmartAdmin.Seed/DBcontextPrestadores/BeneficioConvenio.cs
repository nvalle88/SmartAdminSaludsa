using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class BeneficioConvenio
    {
        public long IdBeneficioConvenio { get; set; }
        public int IdConvenioPlan { get; set; }
        [StringLength(8)]
        public string CodigoBeneficio { get; set; }
        public double Valor { get; set; }
        public bool EsPorcentaje { get; set; }
        public bool? EstadoActivo { get; set; }
        public short CodigoTipoGestionAtencion { get; set; }
        [Column("fec_proceso", TypeName = "datetime")]
        public DateTime? FecProceso { get; set; }
        [Column("fechaUltModificacion", TypeName = "datetime")]
        public DateTime? FechaUltModificacion { get; set; }

        [ForeignKey("IdConvenioPlan")]
        [InverseProperty("BeneficioConvenio")]
        public ConvenioPlan IdConvenioPlanNavigation { get; set; }
    }
}
