using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class Constitucion
    {
        public Constitucion()
        {
            DetalleSobre = new HashSet<DetalleSobre>();
        }

        [Key]
        public int IdConstitucion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaGeneracion { get; set; }
        public int MesDocumento { get; set; }
        public int AñoDocumento { get; set; }
        [Column(TypeName = "decimal(19, 5)")]
        public decimal ValorTotal { get; set; }
        public int CantidadDocumentos { get; set; }

        [InverseProperty("IdConstitucionNavigation")]
        public ICollection<DetalleSobre> DetalleSobre { get; set; }
    }
}
