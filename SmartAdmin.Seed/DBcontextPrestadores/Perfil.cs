using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("PERFIL")]
    public partial class Perfil
    {
        public Perfil()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        [Column("ID_PERFIL", TypeName = "numeric(18, 0)")]
        public decimal IdPerfil { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("PER_NOMBRE")]
        [StringLength(500)]
        public string PerNombre { get; set; }
        [Column("PER_FECHACREACION", TypeName = "datetime")]
        public DateTime? PerFechacreacion { get; set; }
        [Column("PER_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? PerFechaactualizacion { get; set; }
        [Column("PER_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string PerActualizadopor { get; set; }
        [Column("PER_ESCRITURA")]
        public bool? PerEscritura { get; set; }
        [Column("PER_CREADOPOR")]
        [StringLength(100)]
        public string PerCreadopor { get; set; }
        [Column("PER_DESCRIPCION")]
        [StringLength(250)]
        public string PerDescripcion { get; set; }
        [Column("PER_NIVELACCESO")]
        public int? PerNivelacceso { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("Perfil")]
        public Estado IdEstadoNavigation { get; set; }
        [InverseProperty("IdPerfilNavigation")]
        public ICollection<Usuario> Usuario { get; set; }
    }
}
