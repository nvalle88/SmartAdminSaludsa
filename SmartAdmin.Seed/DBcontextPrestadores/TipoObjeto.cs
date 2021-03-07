using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class TipoObjeto
    {
        public TipoObjeto()
        {
            Historial = new HashSet<Historial>();
        }

        [Key]
        public int IdObjeto { get; set; }
        [StringLength(20)]
        public string DescripcionObjeto { get; set; }
        [StringLength(50)]
        public string Estado { get; set; }

        [InverseProperty("IdObjetoNavigation")]
        public ICollection<Historial> Historial { get; set; }
    }
}
