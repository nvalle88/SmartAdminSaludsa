using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class LiteralClausula
    {
        public LiteralClausula()
        {
            DetalleSobreLiteral = new HashSet<DetalleSobreLiteral>();
        }

        [Key]
        public int IdLiteralClausula { get; set; }
        public int IdClausula { get; set; }
        [Required]
        [Column("LiteralClausula")]
        [StringLength(2000)]
        public string LiteralClausula1 { get; set; }

        [ForeignKey("IdClausula")]
        [InverseProperty("LiteralClausula")]
        public Clausula IdClausulaNavigation { get; set; }
        [InverseProperty("IdLiteralClausulaNavigation")]
        public ICollection<DetalleSobreLiteral> DetalleSobreLiteral { get; set; }
    }
}
