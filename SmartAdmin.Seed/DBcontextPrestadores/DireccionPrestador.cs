using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("DIRECCION_PRESTADOR")]
    public partial class DireccionPrestador
    {
        [Key]
        [Column("ID_DIRECCIONPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdDireccionprestador { get; set; }
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdPrestador { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("DIP_CALLEPRINCIPAL")]
        [StringLength(250)]
        public string DipCalleprincipal { get; set; }
        [Column("DIP_TELEFONO1")]
        [StringLength(100)]
        public string DipTelefono1 { get; set; }
        [Column("DIP_TELEFONO2")]
        [StringLength(100)]
        public string DipTelefono2 { get; set; }
        [Column("DIP_TELEFONO3")]
        [StringLength(100)]
        public string DipTelefono3 { get; set; }
        [Column("DIP_FECHACREACION", TypeName = "datetime")]
        public DateTime? DipFechacreacion { get; set; }
        [Column("DIP_CREADOPOR")]
        [StringLength(100)]
        public string DipCreadopor { get; set; }
        [Column("DIP_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? DipFechaactualizacion { get; set; }
        [Column("DIP_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string DipActualizadopor { get; set; }
        [Column("DIP_URLDIRECCION")]
        [StringLength(1000)]
        public string DipUrldireccion { get; set; }
        [Column("DIP_EXTENSION1")]
        [StringLength(10)]
        public string DipExtension1 { get; set; }
        [Column("DIP_EXTENSION2")]
        [StringLength(10)]
        public string DipExtension2 { get; set; }
        [Column("DIP_EXTENSION3")]
        [StringLength(10)]
        public string DipExtension3 { get; set; }
        [Column("DIP_CELULAR1")]
        [StringLength(100)]
        public string DipCelular1 { get; set; }
        [Column("DIP_CELULAR2")]
        [StringLength(100)]
        public string DipCelular2 { get; set; }
        [Column("DIP_CELULAR3")]
        [StringLength(100)]
        public string DipCelular3 { get; set; }
        [Column("DIP_NUMERACION")]
        [StringLength(100)]
        public string DipNumeracion { get; set; }
        [Column("DIP_CALLESECUNDARIA")]
        [StringLength(250)]
        public string DipCallesecundaria { get; set; }
        [Column("DIP_SECTOR")]
        [StringLength(250)]
        public string DipSector { get; set; }
        [Column("DIP_REFERENCIA")]
        [StringLength(500)]
        public string DipReferencia { get; set; }
        [Column("DIP_ATIENDEL")]
        public bool DipAtiendel { get; set; }
        [Column("DIP_ATIENDEM")]
        public bool DipAtiendem { get; set; }
        [Column("DIP_ATIENDEMI")]
        public bool DipAtiendemi { get; set; }
        [Column("DIP_ATIENDEJ")]
        public bool DipAtiendej { get; set; }
        [Column("DIP_ATIENDEV")]
        public bool DipAtiendev { get; set; }
        [Column("DIP_ATIENDES")]
        public bool DipAtiendes { get; set; }
        [Column("DIP_ATIENDED")]
        public bool DipAtiended { get; set; }
        [Column("DIP_HORADESDEL")]
        [StringLength(50)]
        public string DipHoradesdel { get; set; }
        [Column("DIP_HORADESDEM")]
        [StringLength(50)]
        public string DipHoradesdem { get; set; }
        [Column("DIP_HORADESDEMI")]
        [StringLength(50)]
        public string DipHoradesdemi { get; set; }
        [Column("DIP_HORADESDEJ")]
        [StringLength(50)]
        public string DipHoradesdej { get; set; }
        [Column("DIP_HORADESDEV")]
        [StringLength(50)]
        public string DipHoradesdev { get; set; }
        [Column("DIP_HORADESDES")]
        [StringLength(50)]
        public string DipHoradesdes { get; set; }
        [Column("DIP_HORADESDED")]
        [StringLength(50)]
        public string DipHoradesded { get; set; }
        [Column("DIP_HORAHASTAL")]
        [StringLength(50)]
        public string DipHorahastal { get; set; }
        [Column("DIP_HORAHASTAM")]
        [StringLength(50)]
        public string DipHorahastam { get; set; }
        [Column("DIP_HORAHASTAMI")]
        [StringLength(50)]
        public string DipHorahastami { get; set; }
        [Column("DIP_HORAHASTAJ")]
        [StringLength(50)]
        public string DipHorahastaj { get; set; }
        [Column("DIP_HORAHASTAV")]
        [StringLength(50)]
        public string DipHorahastav { get; set; }
        [Column("DIP_HORAHASTAS")]
        [StringLength(50)]
        public string DipHorahastas { get; set; }
        [Column("DIP_HORAHASTAD")]
        [StringLength(50)]
        public string DipHorahastad { get; set; }
        [Column("DIP_OBSERVACIONES")]
        [StringLength(2000)]
        public string DipObservaciones { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("DireccionPrestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPrestador")]
        [InverseProperty("DireccionPrestador")]
        public Prestador IdPrestadorNavigation { get; set; }
    }
}
