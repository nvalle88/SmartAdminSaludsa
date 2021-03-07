using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("PRODUCTO")]
    public partial class Producto
    {
        public Producto()
        {
            ProductoPrestador = new HashSet<ProductoPrestador>();
        }

        [Key]
        [Column("ID_PRODUCTO", TypeName = "numeric(18, 0)")]
        public decimal IdProducto { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }
        [Column("PRD_NOMBRE")]
        [StringLength(100)]
        public string PrdNombre { get; set; }
        [Column("PRD_DESCRIPCION")]
        [StringLength(500)]
        public string PrdDescripcion { get; set; }
        [Column("PRD_FECHACREACION", TypeName = "datetime")]
        public DateTime? PrdFechacreacion { get; set; }
        [Column("PRD_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? PrdFechaactualizacion { get; set; }
        [Column("PRD_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string PrdActualizadopor { get; set; }
        [Column("PRD_CREADOPOR")]
        [StringLength(100)]
        public string PrdCreadopor { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("Producto")]
        public Estado IdEstadoNavigation { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public ICollection<ProductoPrestador> ProductoPrestador { get; set; }
    }
}
