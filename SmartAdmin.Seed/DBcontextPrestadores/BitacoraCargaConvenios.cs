using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("bitacora_carga_convenios")]
    public partial class BitacoraCargaConvenios
    {
        [Key]
        [Column("id_proc")]
        public int IdProc { get; set; }
        [StringLength(60)]
        public string NomArchivo { get; set; }
        [Column("reg_a_procesar")]
        public int? RegAProcesar { get; set; }
        [Column("reg_insert")]
        public int? RegInsert { get; set; }
        [Column("reg_update")]
        public int? RegUpdate { get; set; }
        [Column("fec_inicio", TypeName = "datetime")]
        public DateTime? FecInicio { get; set; }
        [Column("fec_fin", TypeName = "datetime")]
        public DateTime? FecFin { get; set; }
        [Column("host")]
        [StringLength(30)]
        public string Host { get; set; }
        [Column("usuario_proc")]
        [StringLength(30)]
        public string UsuarioProc { get; set; }
        [Column("requerimiento")]
        [StringLength(40)]
        public string Requerimiento { get; set; }
        [Column("tipo_carga")]
        [StringLength(40)]
        public string TipoCarga { get; set; }
        [Column("suma_archivo", TypeName = "numeric(20, 2)")]
        public decimal? SumaArchivo { get; set; }
        [Column("suma_bdd", TypeName = "numeric(20, 2)")]
        public decimal? SumaBdd { get; set; }
        [Column("nro_reg_archivo")]
        public int? NroRegArchivo { get; set; }
        [Column("nro_reg_bdd")]
        public int? NroRegBdd { get; set; }
    }
}
