using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class DetalleSobreLiteral
    {
        [Key]
        public int IdSobreLiteral { get; set; }
        public int IdDetalleSobre { get; set; }
        public int IdLiteralClausula { get; set; }
        public int IdMotivoDevolucion { get; set; }

        [ForeignKey("IdDetalleSobre")]
        [InverseProperty("DetalleSobreLiteral")]
        public DetalleSobre IdDetalleSobreNavigation { get; set; }
        [ForeignKey("IdLiteralClausula")]
        [InverseProperty("DetalleSobreLiteral")]
        public LiteralClausula IdLiteralClausulaNavigation { get; set; }
    }
}
