using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("convenio_valores")]
    public partial class ConvenioValores
    {
        [Column("orden")]
        public int Orden { get; set; }
        public int NumeroConvenio { get; set; }
        [StringLength(200)]
        public string RazonSocial { get; set; }
        [StringLength(200)]
        public string NombreComercial { get; set; }
        [StringLength(3)]
        public string CodigoProducto { get; set; }
        public long NumeroEmpresa { get; set; }
        [Column("lista")]
        public long Lista { get; set; }
        public double? ValFeeConsulta { get; set; }
        [Column("prj_CobLabClinico", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobLabClinico { get; set; }
        [Column("prj_CobImagenes", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobImagenes { get; set; }
        [Column("prj_CobProcedimientos", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobProcedimientos { get; set; }
        [Column("prj_CobMedicinaGenerica", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobMedicinaGenerica { get; set; }
        [Column("prj_CobMedicinaMarca", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobMedicinaMarca { get; set; }
        [Column("prj_CobTerapiaRespiratoria", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobTerapiaRespiratoria { get; set; }
        [Column("prj_CobTerapiaFisica", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobTerapiaFisica { get; set; }
        [Column("prj_CobTerapiaLenguaje", TypeName = "numeric(20, 6)")]
        public decimal? PrjCobTerapiaLenguaje { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaUltModificaion { get; set; }
    }
}
