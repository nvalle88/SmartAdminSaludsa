using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class MotivoDevolucionClausula
    {
        [Key]
        public int IdMotivoClausula { get; set; }
        public int IdClausula { get; set; }
        public int IdMotivoDevolucion { get; set; }

        [ForeignKey("IdClausula")]
        [InverseProperty("MotivoDevolucionClausula")]
        public Clausula IdClausulaNavigation { get; set; }
    }
}
