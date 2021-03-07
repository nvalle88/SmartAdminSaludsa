using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("USUARIO")]
    public partial class Usuario
    {
        [Key]
        [Column("ID_USUARIO", TypeName = "numeric(18, 0)")]
        public decimal IdUsuario { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("ID_REGION", TypeName = "numeric(18, 0)")]
        public decimal? IdRegion { get; set; }
        [Column("ID_PERFIL", TypeName = "numeric(18, 0)")]
        public decimal? IdPerfil { get; set; }
        [Column("USU_NOMBRE")]
        [StringLength(500)]
        public string UsuNombre { get; set; }
        [Column("USU_PRIMERNOMBRE")]
        [StringLength(100)]
        public string UsuPrimernombre { get; set; }
        [Column("USU_SEGUNDONOMBRE")]
        [StringLength(100)]
        public string UsuSegundonombre { get; set; }
        [Column("USU_PRIMERAPELLIDO")]
        [StringLength(100)]
        public string UsuPrimerapellido { get; set; }
        [Column("USU_SEGUNDOAPELLIDO")]
        [StringLength(100)]
        public string UsuSegundoapellido { get; set; }
        [Column("USU_ULTIMOACCESO", TypeName = "datetime")]
        public DateTime? UsuUltimoacceso { get; set; }
        [Column("USU_FECHACREACION", TypeName = "datetime")]
        public DateTime? UsuFechacreacion { get; set; }
        [Column("USU_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? UsuFechaactualizacion { get; set; }
        [Column("USU_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string UsuActualizadopor { get; set; }
        [Column("USU_CREADOPOR")]
        [StringLength(100)]
        public string UsuCreadopor { get; set; }
        [Column("PASSWORD")]
        [StringLength(50)]
        public string Password { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("Usuario")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPerfil")]
        [InverseProperty("Usuario")]
        public Perfil IdPerfilNavigation { get; set; }
        [ForeignKey("IdRegion")]
        [InverseProperty("Usuario")]
        public Region IdRegionNavigation { get; set; }
    }
}
