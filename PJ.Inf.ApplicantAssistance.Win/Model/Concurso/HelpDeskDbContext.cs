using Microsoft.EntityFrameworkCore;
using PJ.Inf.ApplicantAssistance.Win.Utils;

namespace PJ.Inf.ApplicantAssistance.Win.Model.Concurso;

public partial class HelpDeskDbContext : DbContext
{
    public HelpDeskDbContext()
    {
    }

    public HelpDeskDbContext(DbContextOptions<HelpDeskDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Participante> Participantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(Util.LoadConfig().ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Participante>(entity =>
        {
            entity.HasKey(e => e.ParId);

            entity.ToTable("Participante");

            entity.HasIndex(e => e.ParId, "IX_Participante").IsUnique();

            entity.Property(e => e.ParId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ParApellidoMaterno).HasMaxLength(64);
            entity.Property(e => e.ParApellidoPaterno).HasMaxLength(64);
            entity.Property(e => e.ParAula).HasMaxLength(32);
            entity.Property(e => e.ParDependencia).HasMaxLength(128);
            entity.Property(e => e.ParDocumentoIdentidad).HasMaxLength(32);
            entity.Property(e => e.ParEmailPersonal).HasMaxLength(64);
            entity.Property(e => e.ParEmailTrabajo).HasMaxLength(64);
            entity.Property(e => e.ParEstadoIngreso).HasDefaultValueSql("((1))");
            entity.Property(e => e.ParFechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.ParFicha).HasMaxLength(64);
            entity.Property(e => e.ParNombres1).HasMaxLength(64);
            entity.Property(e => e.ParNombres2).HasMaxLength(64);
            entity.Property(e => e.ParNombres3).HasMaxLength(64);
            entity.Property(e => e.ParPlaza).HasMaxLength(128);
            entity.Property(e => e.ParTelefonoDomicilio).HasMaxLength(64);
            entity.Property(e => e.ParTelefonoPersonal).HasMaxLength(64);
            entity.Property(e => e.ParTelefonoTrabajo).HasMaxLength(64);
            entity.Property(e => e.SecActivo)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SecFechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.SecFechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SecFechaEliminacion).HasColumnType("datetime");
            entity.Property(e => e.SecUsuarioActualizacionId).HasMaxLength(64);
            entity.Property(e => e.SecUsuarioCreacionId)
                .HasMaxLength(64)
                .HasDefaultValueSql("(suser_name())");
            entity.Property(e => e.SecUsuarioEliminacionId).HasMaxLength(64);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
