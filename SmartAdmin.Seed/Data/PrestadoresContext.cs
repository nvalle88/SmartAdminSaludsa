using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartAdminSaludsa.DBcontextPrestadores
{
    public partial class PrestadoresContext : DbContext
    {
        public virtual DbSet<ActividadEconomica> ActividadEconomica { get; set; }
        public virtual DbSet<AuditoriaModificacionMaestro> AuditoriaModificacionMaestro { get; set; }
        public virtual DbSet<AuPrestadores> AuPrestadores { get; set; }
        public virtual DbSet<BeneficioConvenio> BeneficioConvenio { get; set; }
        public virtual DbSet<BinesTarjeta> BinesTarjeta { get; set; }
        public virtual DbSet<BitacoraCargaConvenios> BitacoraCargaConvenios { get; set; }
        public virtual DbSet<CargaPlanes> CargaPlanes { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Clausula> Clausula { get; set; }
        public virtual DbSet<ComisionDirector> ComisionDirector { get; set; }
        public virtual DbSet<ComisionDirectorDetalle> ComisionDirectorDetalle { get; set; }
        public virtual DbSet<ComisionVendedor> ComisionVendedor { get; set; }
        public virtual DbSet<ComisionVendedorDetalle> ComisionVendedorDetalle { get; set; }
        public virtual DbSet<Constitucion> Constitucion { get; set; }
        public virtual DbSet<ConvenioPlan> ConvenioPlan { get; set; }
        public virtual DbSet<ConvenioValores> ConvenioValores { get; set; }
        public virtual DbSet<CorreoPrestador> CorreoPrestador { get; set; }
        public virtual DbSet<DetalleSobre> DetalleSobre { get; set; }
        public virtual DbSet<DetalleSobreLiteral> DetalleSobreLiteral { get; set; }
        public virtual DbSet<DireccionPrestador> DireccionPrestador { get; set; }
        public virtual DbSet<DocumentoPrestador> DocumentoPrestador { get; set; }
        public virtual DbSet<EspecialidadPrestador> EspecialidadPrestador { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<EstudiosPrestador> EstudiosPrestador { get; set; }
        public virtual DbSet<Historial> Historial { get; set; }
        public virtual DbSet<LiteralClausula> LiteralClausula { get; set; }
        public virtual DbSet<MotivoDevolucionClausula> MotivoDevolucionClausula { get; set; }
        public virtual DbSet<NivelAtencion> NivelAtencion { get; set; }
        public virtual DbSet<NivelComplejidad> NivelComplejidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Prestador> Prestador { get; set; }
        public virtual DbSet<PrestadorCeroTramites> PrestadorCeroTramites { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoPrestador> ProductoPrestador { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<ServicioAdicionalComisionNovedad> ServicioAdicionalComisionNovedad { get; set; }
        public virtual DbSet<TipoCorreo> TipoCorreo { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public virtual DbSet<TipoObjeto> TipoObjeto { get; set; }
        public virtual DbSet<TipoPrestador> TipoPrestador { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        // Unable to generate entity type for table 'dbo.planes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.planesConvenio'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mig_bene'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Borrar_SmartTmpPlanesSmart'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Borrar_TmpPlanesCorporativoPuro'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.convenios'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.resp_BeneficioConvenio_borrados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.beneficio_retirado'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Pre_ConvenioPlan'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PruebaDatosProgress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.carga_convenio_excel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESP_05_2019ConvenioPlan'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESP_05_2019BeneficioConvenio'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.iteracion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpDatosArchivos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WrkConvenios'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WrkPrestadores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WrkPlanes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WrkPrestadorInterEcua'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BeneficioConvenio_Backup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EmpresaPool'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PlanIndividualConvenio'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ConvenioPlan_Backup'. Please see the warning messages.

        public PrestadoresContext(DbContextOptions<PrestadoresContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActividadEconomica>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_38_FK");

                entity.Property(e => e.IdActividadeconomica).ValueGeneratedOnAdd();

                entity.Property(e => e.ActActualizadopor).IsUnicode(false);

                entity.Property(e => e.ActCreadopor).IsUnicode(false);

                entity.Property(e => e.ActNombre).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.ActividadEconomica)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_ACTIVIDA_RELATIONS_ESTADO");
            });

            modelBuilder.Entity<AuditoriaModificacionMaestro>(entity =>
            {
                entity.Property(e => e.EstadoInicial).IsUnicode(false);

                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Identidad).IsUnicode(false);

                entity.Property(e => e.Programa).IsUnicode(false);

                entity.Property(e => e.Ruta).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);
            });

            modelBuilder.Entity<AuPrestadores>(entity =>
            {
                entity.HasIndex(e => e.Usuario)
                    .HasName("idxUsuario");

                entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Host)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Objeto).IsUnicode(false);

                entity.Property(e => e.Operacion).IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<BeneficioConvenio>(entity =>
            {
                entity.HasKey(e => new { e.IdConvenioPlan, e.CodigoBeneficio, e.CodigoTipoGestionAtencion });

                entity.HasIndex(e => e.CodigoBeneficio)
                    .HasName("idxCodigoBenef");

                entity.HasIndex(e => new { e.IdConvenioPlan, e.CodigoBeneficio, e.CodigoTipoGestionAtencion })
                    .HasName("Idx_BeneficioConvenio")
                    .IsUnique();

                entity.Property(e => e.CodigoBeneficio).IsUnicode(false);

                entity.Property(e => e.CodigoTipoGestionAtencion).HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FecProceso).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdBeneficioConvenio).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdConvenioPlanNavigation)
                    .WithMany(p => p.BeneficioConvenio)
                    .HasForeignKey(d => d.IdConvenioPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BeneficioConvenio_ConvenioPlan");
            });

            modelBuilder.Entity<BinesTarjeta>(entity =>
            {
                entity.HasKey(e => new { e.Bines, e.Entidad, e.Tipo });
            });

            modelBuilder.Entity<BitacoraCargaConvenios>(entity =>
            {
                entity.Property(e => e.FecInicio).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Host)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.NomArchivo).IsUnicode(false);

                entity.Property(e => e.NroRegArchivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NroRegBdd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Requerimiento).IsUnicode(false);

                entity.Property(e => e.SumaArchivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SumaBdd).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCarga).IsUnicode(false);

                entity.Property(e => e.UsuarioProc)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<CargaPlanes>(entity =>
            {
                entity.HasIndex(e => new { e.NumeroConvenio, e.CodigoProducto, e.CodigoPlan, e.EsPromocion, e.NombrePromocion })
                    .HasName("UX_CargaPlanes")
                    .IsUnique();

                entity.Property(e => e.CodigoPlan).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.NombrePromocion).IsUnicode(false);

                entity.Property(e => e.NumeroConvenio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Version).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasIndex(e => e.IdProvincia)
                    .HasName("RELATIONSHIP_32_FK");

                entity.Property(e => e.IdCiudad).ValueGeneratedOnAdd();

                entity.Property(e => e.CiuActualizadopor).IsUnicode(false);

                entity.Property(e => e.CiuCodigosri).IsUnicode(false);

                entity.Property(e => e.CiuCreadopor).IsUnicode(false);

                entity.Property(e => e.CiuNombre).IsUnicode(false);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_CIUDAD_RELATIONS_PROVINCI");
            });

            modelBuilder.Entity<ComisionDirectorDetalle>(entity =>
            {
                entity.HasOne(d => d.IdComisionDirectorNavigation)
                    .WithMany(p => p.ComisionDirectorDetalle)
                    .HasForeignKey(d => d.IdComisionDirector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComisionDirectorDetalle_IdComisionDirector_ComisionDirector_Id");
            });

            modelBuilder.Entity<ComisionVendedorDetalle>(entity =>
            {
                entity.HasOne(d => d.IdComisionVendedorNavigation)
                    .WithMany(p => p.ComisionVendedorDetalle)
                    .HasForeignKey(d => d.IdComisionVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComisionVendedorDetalle_IdComisionVendedor_ComisionVendedor_Id");
            });

            modelBuilder.Entity<ConvenioPlan>(entity =>
            {
                entity.HasIndex(e => new { e.NumeroConvenio, e.CodigoProducto, e.CodigoPlan, e.VersionPlan })
                    .HasName("UX_ConvenioPlan")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdConvenioPlan, e.NumeroConvenio, e.CodigoPlan, e.FechaInicioVigencia, e.EsPromocion, e.NombrePromocion, e.VersionPlan, e.FecProceso, e.FechaUltModificacion, e.CodigoProducto, e.FechaFinVigencia })
                    .HasName("IdxProductoVigencia");

                entity.Property(e => e.CodigoPlan).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.FecProceso).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombrePromocion).IsUnicode(false);
            });

            modelBuilder.Entity<ConvenioValores>(entity =>
            {
                entity.HasKey(e => new { e.NumeroConvenio, e.CodigoProducto, e.NumeroEmpresa, e.Lista });

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.FechaIngreso).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreComercial).IsUnicode(false);

                entity.Property(e => e.Orden).ValueGeneratedOnAdd();

                entity.Property(e => e.RazonSocial).IsUnicode(false);
            });

            modelBuilder.Entity<CorreoPrestador>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_35_FK");

                entity.HasIndex(e => e.IdPrestador)
                    .HasName("RELATIONSHIP_37_FK");

                entity.HasIndex(e => e.IdTipocorreo)
                    .HasName("RELATIONSHIP_36_FK");

                entity.Property(e => e.IdPrestadorcorreo).ValueGeneratedOnAdd();

                entity.Property(e => e.CprActualizadopor).IsUnicode(false);

                entity.Property(e => e.CprCorreo).IsUnicode(false);

                entity.Property(e => e.CprCreadopor).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CorreoPrestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_CORREO_P_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.CorreoPrestador)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_CORREO_P_RELATIONS_PRESTADO");

                entity.HasOne(d => d.IdTipocorreoNavigation)
                    .WithMany(p => p.CorreoPrestador)
                    .HasForeignKey(d => d.IdTipocorreo)
                    .HasConstraintName("FK_CORREO_P_RELATIONS_TIPO_COR");
            });

            modelBuilder.Entity<DetalleSobre>(entity =>
            {
                entity.HasOne(d => d.IdConstitucionNavigation)
                    .WithMany(p => p.DetalleSobre)
                    .HasForeignKey(d => d.IdConstitucion)
                    .HasConstraintName("FK_DetalleSobre_IdConstitucion_Constitucion_IdConstitucion");
            });

            modelBuilder.Entity<DetalleSobreLiteral>(entity =>
            {
                entity.HasOne(d => d.IdDetalleSobreNavigation)
                    .WithMany(p => p.DetalleSobreLiteral)
                    .HasForeignKey(d => d.IdDetalleSobre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleSobreLiteral_IdDetalleSobre_DetalleSobre_IdDetalleSobre");

                entity.HasOne(d => d.IdLiteralClausulaNavigation)
                    .WithMany(p => p.DetalleSobreLiteral)
                    .HasForeignKey(d => d.IdLiteralClausula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleSobreLiteral_IdLiteralClausula_LiteralClausula_IdLiteralClausula");
            });

            modelBuilder.Entity<DireccionPrestador>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_45_FK");

                entity.HasIndex(e => e.IdPrestador)
                    .HasName("RELATIONSHIP_15_FK");

                entity.Property(e => e.IdDireccionprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.DipActualizadopor).IsUnicode(false);

                entity.Property(e => e.DipCalleprincipal).IsUnicode(false);

                entity.Property(e => e.DipCallesecundaria).IsUnicode(false);

                entity.Property(e => e.DipCelular1).IsUnicode(false);

                entity.Property(e => e.DipCelular2).IsUnicode(false);

                entity.Property(e => e.DipCelular3).IsUnicode(false);

                entity.Property(e => e.DipCreadopor).IsUnicode(false);

                entity.Property(e => e.DipExtension1).IsUnicode(false);

                entity.Property(e => e.DipExtension2).IsUnicode(false);

                entity.Property(e => e.DipExtension3).IsUnicode(false);

                entity.Property(e => e.DipHoradesded).IsUnicode(false);

                entity.Property(e => e.DipHoradesdej).IsUnicode(false);

                entity.Property(e => e.DipHoradesdel).IsUnicode(false);

                entity.Property(e => e.DipHoradesdem).IsUnicode(false);

                entity.Property(e => e.DipHoradesdemi).IsUnicode(false);

                entity.Property(e => e.DipHoradesdes).IsUnicode(false);

                entity.Property(e => e.DipHoradesdev).IsUnicode(false);

                entity.Property(e => e.DipHorahastad).IsUnicode(false);

                entity.Property(e => e.DipHorahastaj).IsUnicode(false);

                entity.Property(e => e.DipHorahastal).IsUnicode(false);

                entity.Property(e => e.DipHorahastam).IsUnicode(false);

                entity.Property(e => e.DipHorahastami).IsUnicode(false);

                entity.Property(e => e.DipHorahastas).IsUnicode(false);

                entity.Property(e => e.DipHorahastav).IsUnicode(false);

                entity.Property(e => e.DipNumeracion).IsUnicode(false);

                entity.Property(e => e.DipObservaciones).IsUnicode(false);

                entity.Property(e => e.DipReferencia).IsUnicode(false);

                entity.Property(e => e.DipSector).IsUnicode(false);

                entity.Property(e => e.DipTelefono1).IsUnicode(false);

                entity.Property(e => e.DipTelefono2).IsUnicode(false);

                entity.Property(e => e.DipTelefono3).IsUnicode(false);

                entity.Property(e => e.DipUrldireccion).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.DireccionPrestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_DIRECCIO_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.DireccionPrestador)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_DIRECCIO_RELATIONS_PRESTADO");
            });

            modelBuilder.Entity<DocumentoPrestador>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_43_FK");

                entity.HasIndex(e => e.IdPrestador)
                    .HasName("RELATIONSHIP_42_FK");

                entity.HasIndex(e => e.IdTipodocumento)
                    .HasName("RELATIONSHIP_41_FK");

                entity.Property(e => e.IdDocumentoprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.DprActualizadopor).IsUnicode(false);

                entity.Property(e => e.DprCreadopor).IsUnicode(false);

                entity.Property(e => e.DprNombre).IsUnicode(false);

                entity.Property(e => e.DprTipocontenido).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.DocumentoPrestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_DOCUMENT_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.DocumentoPrestador)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_DOCUMENT_RELATIONS_PRESTADO");

                entity.HasOne(d => d.IdTipodocumentoNavigation)
                    .WithMany(p => p.DocumentoPrestador)
                    .HasForeignKey(d => d.IdTipodocumento)
                    .HasConstraintName("FK_DOCUMENT_RELATIONS_TIPO_DOC");
            });

            modelBuilder.Entity<EspecialidadPrestador>(entity =>
            {
                entity.HasIndex(e => e.IdPrestador)
                    .HasName("RELATIONSHIP_19_FK");

                entity.Property(e => e.IdEspecialidadprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.EppActualizadopor).IsUnicode(false);

                entity.Property(e => e.EppCreadopor).IsUnicode(false);

                entity.Property(e => e.EppEspecialidad).IsUnicode(false);

                entity.Property(e => e.EppMedico).IsUnicode(false);

                entity.Property(e => e.EppSubespecialidad).IsUnicode(false);

                entity.Property(e => e.IdEspecialidad).IsUnicode(false);

                entity.Property(e => e.IdSubespecialidad).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.EspecialidadPrestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_ESPEC_P_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.EspecialidadPrestador)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_ESPECIAL_RELATIONS_PRESTADO");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.IdEstado).ValueGeneratedOnAdd();

                entity.Property(e => e.EstActualizadopor).IsUnicode(false);

                entity.Property(e => e.EstCreadopor).IsUnicode(false);

                entity.Property(e => e.EstNombre).IsUnicode(false);
            });

            modelBuilder.Entity<EstudiosPrestador>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_44_FK");

                entity.HasIndex(e => e.IdPrestador)
                    .HasName("RELATIONSHIP_22_FK");

                entity.Property(e => e.IdEstudioprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.EspActualizadopor).IsUnicode(false);

                entity.Property(e => e.EspCreadopor).IsUnicode(false);

                entity.Property(e => e.EspNombre).IsUnicode(false);

                entity.Property(e => e.EspUniversidad).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.EstudiosPrestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_TITULO_P_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.EstudiosPrestador)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK_TITULO_P_RELATIONS_PAIS");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.EstudiosPrestador)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_TITULO_P_RELATIONS_PRESTADO");
            });

            modelBuilder.Entity<Historial>(entity =>
            {
                entity.HasOne(d => d.IdObjetoNavigation)
                    .WithMany(p => p.Historial)
                    .HasForeignKey(d => d.IdObjeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Historial_IdObjeto_TipoObjeto_IdObjeto");
            });

            modelBuilder.Entity<LiteralClausula>(entity =>
            {
                entity.HasOne(d => d.IdClausulaNavigation)
                    .WithMany(p => p.LiteralClausula)
                    .HasForeignKey(d => d.IdClausula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiteralClausula_IdClausula_Clausula_IdClausula");
            });

            modelBuilder.Entity<MotivoDevolucionClausula>(entity =>
            {
                entity.HasOne(d => d.IdClausulaNavigation)
                    .WithMany(p => p.MotivoDevolucionClausula)
                    .HasForeignKey(d => d.IdClausula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotivoDevolucionClausula_IdClausula_Clausula_IdClausula");
            });

            modelBuilder.Entity<NivelAtencion>(entity =>
            {
                entity.Property(e => e.IdNivelatencion).ValueGeneratedOnAdd();

                entity.Property(e => e.NatActualizadopor).IsUnicode(false);

                entity.Property(e => e.NatCreadopor).IsUnicode(false);

                entity.Property(e => e.NatNombre).IsUnicode(false);
            });

            modelBuilder.Entity<NivelComplejidad>(entity =>
            {
                entity.Property(e => e.IdNivelcomplejidad).ValueGeneratedOnAdd();

                entity.Property(e => e.NcoActualizadopor).IsUnicode(false);

                entity.Property(e => e.NcoCreadopor).IsUnicode(false);

                entity.Property(e => e.NcoNombre).IsUnicode(false);
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.IdPais).ValueGeneratedOnAdd();

                entity.Property(e => e.PaiActualizadopor).IsUnicode(false);

                entity.Property(e => e.PaiCreadopor).IsUnicode(false);

                entity.Property(e => e.PaiNombre).IsUnicode(false);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_1_FK");

                entity.Property(e => e.IdPerfil).ValueGeneratedOnAdd();

                entity.Property(e => e.PerActualizadopor).IsUnicode(false);

                entity.Property(e => e.PerCreadopor).IsUnicode(false);

                entity.Property(e => e.PerDescripcion).IsUnicode(false);

                entity.Property(e => e.PerNombre).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Perfil)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_PERFIL_RELATIONS_ESTADO");
            });

            modelBuilder.Entity<Prestador>(entity =>
            {
                entity.HasIndex(e => e.IdActividadeconomica)
                    .HasName("RELATIONSHIP_39_FK");

                entity.HasIndex(e => e.IdCiudad)
                    .HasName("RELATIONSHIP_33_FK");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_46_FK");

                entity.HasIndex(e => e.IdNivelatencion)
                    .HasName("RELATIONSHIP_12_FK");

                entity.HasIndex(e => e.IdNivelcomplejidad)
                    .HasName("RELATIONSHIP_14_FK");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("RELATIONSHIP_29_FK");

                entity.HasIndex(e => e.IdTipoidentificacion)
                    .HasName("RELATIONSHIP_25_FK");

                entity.HasIndex(e => e.IdTipoprestador)
                    .HasName("RELATIONSHIP_9_FK");

                entity.HasIndex(e => e.PreIdentificacion)
                    .HasName("UC_IDENTIFICACION")
                    .IsUnique();

                entity.Property(e => e.IdPrestador).ValueGeneratedOnAdd();

                entity.Property(e => e.PreActualizadopor).IsUnicode(false);

                entity.Property(e => e.PreCreadopor).IsUnicode(false);

                entity.Property(e => e.PreIdentificacion).IsUnicode(false);

                entity.Property(e => e.PreNombrecomercial).IsUnicode(false);

                entity.Property(e => e.PreRazonsocial).IsUnicode(false);

                entity.HasOne(d => d.IdActividadeconomicaNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdActividadeconomica)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_ACTIVIDA");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_CIUDAD");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdNivelatencionNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdNivelatencion)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_NIVEL_AT");

                entity.HasOne(d => d.IdNivelcomplejidadNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdNivelcomplejidad)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_NIVEL_CO");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_PRESTADOR_RELATIONS_PROVINCIA");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_REGION");

                entity.HasOne(d => d.IdTipoidentificacionNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdTipoidentificacion)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_TIPO_IDE");

                entity.HasOne(d => d.IdTipoprestadorNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.IdTipoprestador)
                    .HasConstraintName("FK_PRESTADO_RELATIONS_TIPO_PRE");
            });

            modelBuilder.Entity<PrestadorCeroTramites>(entity =>
            {
                entity.Property(e => e.FeeConsultaA002).HasDefaultValueSql("((0))");

                entity.Property(e => e.LaboratorioClinicoA003).HasDefaultValueSql("((0))");

                entity.Property(e => e.LaboratorioImagenA004).HasDefaultValueSql("((0))");

                entity.Property(e => e.MedicinaGenericaA011).HasDefaultValueSql("((0))");

                entity.Property(e => e.MedicinaMarcaA010).HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreComercial).IsUnicode(false);

                entity.Property(e => e.NombrePrestador).IsUnicode(false);

                entity.Property(e => e.ProcedimientosA005).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ruc).IsUnicode(false);

                entity.Property(e => e.TerapiaFisicaAh03).HasDefaultValueSql("((0))");

                entity.Property(e => e.TerapiaLenguajeAh02).HasDefaultValueSql("((0))");

                entity.Property(e => e.TerapiaRespiratoriaAh01).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.IdProducto).ValueGeneratedOnAdd();

                entity.Property(e => e.PrdActualizadopor).IsUnicode(false);

                entity.Property(e => e.PrdCreadopor).IsUnicode(false);

                entity.Property(e => e.PrdDescripcion).IsUnicode(false);

                entity.Property(e => e.PrdNombre).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_PRODUCTO_RELATIONS_ESTADO");
            });

            modelBuilder.Entity<ProductoPrestador>(entity =>
            {
                entity.Property(e => e.IdProductoprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.PprActualizadopor).IsUnicode(false);

                entity.Property(e => e.PprCreadopor).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.ProductoPrestador)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_PRODU_P_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.ProductoPrestador)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_PRODUCTO_RELATIONS_PRESTADO");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoPrestador)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_PRODU_RELATIONS_PRESTADO");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.IdProvincia).ValueGeneratedOnAdd();

                entity.Property(e => e.PrvActualizadopor).IsUnicode(false);

                entity.Property(e => e.PrvCreadopor).IsUnicode(false);

                entity.Property(e => e.PrvNombre).IsUnicode(false);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.IdRegion).ValueGeneratedOnAdd();

                entity.Property(e => e.RegActualizadopor).IsUnicode(false);

                entity.Property(e => e.RegCreadopor).IsUnicode(false);

                entity.Property(e => e.RegNombre).IsUnicode(false);
            });

            modelBuilder.Entity<TipoCorreo>(entity =>
            {
                entity.Property(e => e.IdTipocorreo).ValueGeneratedOnAdd();

                entity.Property(e => e.TicActualizadopor).IsUnicode(false);

                entity.Property(e => e.TicCreadopor).IsUnicode(false);

                entity.Property(e => e.TicNombre).IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.Property(e => e.IdTipodocumento).ValueGeneratedOnAdd();

                entity.Property(e => e.TdcActualizadopor).IsUnicode(false);

                entity.Property(e => e.TdcCodigo).IsUnicode(false);

                entity.Property(e => e.TdcCreadopor).IsUnicode(false);

                entity.Property(e => e.TdcNombre).IsUnicode(false);
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.Property(e => e.IdTipoidentificacion).ValueGeneratedOnAdd();

                entity.Property(e => e.TidAbreviatura).IsUnicode(false);

                entity.Property(e => e.TidActualizadopor).IsUnicode(false);

                entity.Property(e => e.TidCreadopor).IsUnicode(false);

                entity.Property(e => e.TidNombre).IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestador>(entity =>
            {
                entity.Property(e => e.IdTipoprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.TprActualizadopor).IsUnicode(false);

                entity.Property(e => e.TprCreadopor).IsUnicode(false);

                entity.Property(e => e.TprNombre).IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(e => e.IdEstado)
                    .HasName("RELATIONSHIP_3_FK");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("RELATIONSHIP_5_FK");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("RELATIONSHIP_4_FK");

                entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UsuActualizadopor).IsUnicode(false);

                entity.Property(e => e.UsuCreadopor).IsUnicode(false);

                entity.Property(e => e.UsuNombre).IsUnicode(false);

                entity.Property(e => e.UsuPrimerapellido).IsUnicode(false);

                entity.Property(e => e.UsuPrimernombre).IsUnicode(false);

                entity.Property(e => e.UsuSegundoapellido).IsUnicode(false);

                entity.Property(e => e.UsuSegundonombre).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_USUARIO_RELATIONS_ESTADO");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK_USUARIO_RELATIONS_PERFIL");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_USUARIO_RELATIONS_REGION");
            });
        }
    }
}
