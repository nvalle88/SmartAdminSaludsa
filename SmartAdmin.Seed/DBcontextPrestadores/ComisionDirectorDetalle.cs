using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class ComisionDirectorDetalle
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string CodigoProducto { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; }
        public int IdComisionDirector { get; set; }

        [ForeignKey("IdComisionDirector")]
        [InverseProperty("ComisionDirectorDetalle")]
        public ComisionDirector IdComisionDirectorNavigation { get; set; }
    }
}
