using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("CIUDAD")]
    public partial class Ciudad
    {
        public Ciudad()
        {
            Prestador = new HashSet<Prestador>();
        }

        [Key]
        [Column("ID_CIUDAD", TypeName = "numeric(18, 0)")]
        public decimal IdCiudad { get; set; }
        [Column("ID_PROVINCIA", TypeName = "numeric(18, 0)")]
        public decimal? IdProvincia { get; set; }
        [Column("CIU_NOMBRE")]
        [StringLength(500)]
        public string CiuNombre { get; set; }
        [Column("CIU_FECHACREACION", TypeName = "datetime")]
        public DateTime? CiuFechacreacion { get; set; }
        [Column("CIU_CREADOPOR")]
        [StringLength(100)]
        public string CiuCreadopor { get; set; }
        [Column("CIU_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? CiuFechaactualizacion { get; set; }
        [Column("CIU_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string CiuActualizadopor { get; set; }
        [Column("CIU_CODIGOSRI")]
        [StringLength(20)]
        public string CiuCodigosri { get; set; }

        [ForeignKey("IdProvincia")]
        [InverseProperty("Ciudad")]
        public Provincia IdProvinciaNavigation { get; set; }
        [InverseProperty("IdCiudadNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
    }
}
