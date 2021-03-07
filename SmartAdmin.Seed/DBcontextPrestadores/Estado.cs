using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    [Table("ESTADO")]
    public partial class Estado
    {
        public Estado()
        {
            ActividadEconomica = new HashSet<ActividadEconomica>();
            CorreoPrestador = new HashSet<CorreoPrestador>();
            DireccionPrestador = new HashSet<DireccionPrestador>();
            DocumentoPrestador = new HashSet<DocumentoPrestador>();
            EspecialidadPrestador = new HashSet<EspecialidadPrestador>();
            EstudiosPrestador = new HashSet<EstudiosPrestador>();
            Perfil = new HashSet<Perfil>();
            Prestador = new HashSet<Prestador>();
            Producto = new HashSet<Producto>();
            ProductoPrestador = new HashSet<ProductoPrestador>();
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        [Column("ID_ESTADO", TypeName = "numeric(18, 0)")]
        public decimal IdEstado { get; set; }
        [Column("EST_NOMBRE")]
        [StringLength(500)]
        public string EstNombre { get; set; }
        [Column("EST_FECHACREACION", TypeName = "datetime")]
        public DateTime? EstFechacreacion { get; set; }
        [Column("EST_FECHAACTUALIZACION", TypeName = "datetime")]
        public DateTime? EstFechaactualizacion { get; set; }
        [Column("EST_ACTUALIZADOPOR")]
        [StringLength(100)]
        public string EstActualizadopor { get; set; }
        [Column("EST_CREADOPOR")]
        [StringLength(100)]
        public string EstCreadopor { get; set; }

        [InverseProperty("IdEstadoNavigation")]
        public ICollection<ActividadEconomica> ActividadEconomica { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<CorreoPrestador> CorreoPrestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<DireccionPrestador> DireccionPrestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<DocumentoPrestador> DocumentoPrestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<EspecialidadPrestador> EspecialidadPrestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<EstudiosPrestador> EstudiosPrestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<Perfil> Perfil { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<Prestador> Prestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<Producto> Producto { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<ProductoPrestador> ProductoPrestador { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public ICollection<Usuario> Usuario { get; set; }
    }
}
