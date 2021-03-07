using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class ComisionDirector
    {
        public ComisionDirector()
        {
            ComisionDirectorDetalle = new HashSet<ComisionDirectorDetalle>();
        }

        public int Id { get; set; }
        public int IdSala { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorComision { get; set; }
        public int PorcentajeComision { get; set; }
        public bool Cumple { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TotalVentas { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TotalAnulaciones { get; set; }

        [InverseProperty("IdComisionDirectorNavigation")]
        public ICollection<ComisionDirectorDetalle> ComisionDirectorDetalle { get; set; }
    }
}
