using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class PrestadorCeroTramites
    {
        [Key]
        public int IdPrestador { get; set; }
        public int NumeroConvenio { get; set; }
        [Required]
        [StringLength(100)]
        public string NombrePrestador { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreComercial { get; set; }
        [StringLength(13)]
        public string Ruc { get; set; }
        [Column("FeeConsulta_A002")]
        public double FeeConsultaA002 { get; set; }
        [Column("LaboratorioClinico_A003")]
        public double LaboratorioClinicoA003 { get; set; }
        [Column("LaboratorioImagen_A004")]
        public double LaboratorioImagenA004 { get; set; }
        [Column("Procedimientos_A005")]
        public double ProcedimientosA005 { get; set; }
        [Column("MedicinaGenerica_A011")]
        public double MedicinaGenericaA011 { get; set; }
        [Column("MedicinaMarca_A010")]
        public double MedicinaMarcaA010 { get; set; }
        [Column("TerapiaRespiratoria_AH01")]
        public double TerapiaRespiratoriaAh01 { get; set; }
        [Column("TerapiaFisica_AH03")]
        public double TerapiaFisicaAh03 { get; set; }
        [Column("TerapiaLenguaje_AH02")]
        public double TerapiaLenguajeAh02 { get; set; }
    }
}
