using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class ComisionVendedor
    {
        public ComisionVendedor()
        {
            ComisionVendedorDetalle = new HashSet<ComisionVendedorDetalle>();
        }

        public int Id { get; set; }
        public int CodigoAgenteVenta { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalTransPositivas { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalTransNegativas { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorComision { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorDobleComision { get; set; }
        public int PorcentajeComision { get; set; }
        public int PorcentajeDobleComision { get; set; }
        public bool UsoComodin { get; set; }
        [StringLength(100)]
        public string Rango { get; set; }

        [InverseProperty("IdComisionVendedorNavigation")]
        public ICollection<ComisionVendedorDetalle> ComisionVendedorDetalle { get; set; }
    }
}
