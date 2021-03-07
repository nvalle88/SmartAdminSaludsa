using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class ServicioAdicionalComisionNovedad
    {
        public int Id { get; set; }
        public int? CodigoTransaccion { get; set; }
        [StringLength(10)]
        public string CodigoProducto { get; set; }
        public int? ContratoNumero { get; set; }
        [StringLength(10)]
        public string Region { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaMovimiento { get; set; }
        public int? PersonaNumero { get; set; }
        public int? CodigoServicio { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? PrecioCalculo { get; set; }
        public bool? Comisiona { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaNovedad { get; set; }
        [StringLength(100)]
        public string Usuario { get; set; }
        [StringLength(1000)]
        public string Observacion { get; set; }
    }
}
