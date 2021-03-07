using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class Clausula
    {
        public Clausula()
        {
            LiteralClausula = new HashSet<LiteralClausula>();
            MotivoDevolucionClausula = new HashSet<MotivoDevolucionClausula>();
        }

        [Key]
        public int IdClausula { get; set; }
        [Required]
        [StringLength(200)]
        public string TituloClausula { get; set; }
        [Required]
        [StringLength(4000)]
        public string DetalleClausula { get; set; }

        [InverseProperty("IdClausulaNavigation")]
        public ICollection<LiteralClausula> LiteralClausula { get; set; }
        [InverseProperty("IdClausulaNavigation")]
        public ICollection<MotivoDevolucionClausula> MotivoDevolucionClausula { get; set; }
    }
}
