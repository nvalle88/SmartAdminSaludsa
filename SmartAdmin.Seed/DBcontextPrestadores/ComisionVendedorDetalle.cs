using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class ComisionVendedorDetalle
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string TipoProducto { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; }
        public int IdComisionVendedor { get; set; }

        [ForeignKey("IdComisionVendedor")]
        [InverseProperty("ComisionVendedorDetalle")]
        public ComisionVendedor IdComisionVendedorNavigation { get; set; }
    }
}
