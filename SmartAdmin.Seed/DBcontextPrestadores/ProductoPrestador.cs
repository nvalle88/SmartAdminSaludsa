using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("PRODUCTO_PRESTADOR")]
    public partial class ProductoPrestador
    {
        [Key]
        [Column("ID_PRODUCTOPRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal IdProductoprestador { get; set; }
        [Column("ID_PRESTADOR", TypeName = "numeric(18, 0)")]
        public decimal? IdPrestador { get; set; }
        [Column("ID_PRODUCTO", TypeName = "numeric(18, 0)")]
        public decimal? IdProducto { get; set; }
        [Column("PPR_FECHACREACION", TypeName = "datetime")]
        public DateTime? PprFechacreacion { get; set; }
        [Column("PPR_CREADOPOR")]
        [StringLength(100)]
        public string PprCreadopor { get; set; }
        [Column("PPR_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? PprFechaactualizacion { get; set; }
        [Column("PPR_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string PprActualizadopor { get; set; }
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal? IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        [InverseProperty("ProductoPrestador")]
        public Estado IdEstadoNavigation { get; set; }
        [ForeignKey("IdPrestador")]
        [InverseProperty("ProductoPrestador")]
        public Prestador IdPrestadorNavigation { get; set; }
        [ForeignKey("IdProducto")]
        [InverseProperty("ProductoPrestador")]
        public Producto IdProductoNavigation { get; set; }
    }
}
