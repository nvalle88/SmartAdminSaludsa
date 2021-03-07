using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class Historial
    {
        [Key]
        public int IdHistorial { get; set; }
        public int IdObjeto { get; set; }
        [Required]
        [StringLength(50)]
        public string Accion { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaModificacion { get; set; }
        [Required]
        [StringLength(10)]
        public string HoraModificacion { get; set; }
        public string Seguimiento { get; set; }
        [StringLength(50)]
        public string NumeroDocumento { get; set; }
        [StringLength(50)]
        public string UsuarioModificacion { get; set; }

        [ForeignKey("IdObjeto")]
        [InverseProperty("Historial")]
        public TipoObjeto IdObjetoNavigation { get; set; }
    }
}
