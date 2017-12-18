namespace Zoo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZooContext : DbContext
    {
        public ZooContext()
            : base("name=ZooContext")
        {
        }

        public virtual DbSet<BesökHosVeterinär> BesökHosVeterinär { get; set; }
        public virtual DbSet<Boendemiljö> Boendemiljö { get; set; }
        public virtual DbSet<Diagnos> Diagnos { get; set; }
        public virtual DbSet<Djur> Djur { get; set; }
        public virtual DbSet<DjurArt> DjurArt { get; set; }
        public virtual DbSet<DjurTyp> DjurTyp { get; set; }
        public virtual DbSet<Föräldrar> Föräldrar { get; set; }
        public virtual DbSet<MedicinTillDiagnos> MedicinTillDiagnos { get; set; }
        public virtual DbSet<Ursprungsland> Ursprungsland { get; set; }
        public virtual DbSet<Veterinär> Veterinär { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boendemiljö>()
                .Property(e => e.Benämning)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnos>()
                .Property(e => e.Namn)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnos>()
                .Property(e => e.Beskrivning)
                .IsUnicode(false);

            modelBuilder.Entity<Djur>()
                .Property(e => e.Namn)
                .IsUnicode(false);

            modelBuilder.Entity<Djur>()
                .HasMany(e => e.BesökHosVeterinär)
                .WithOptional(e => e.Djur)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Djur>()
                .HasMany(e => e.Föräldrar1)
                .WithOptional(e => e.Djur1)
                .HasForeignKey(e => e.MammaID);

            modelBuilder.Entity<Djur>()
                .HasMany(e => e.Föräldrar2)
                .WithOptional(e => e.Djur2)
                .HasForeignKey(e => e.PappaID);

            modelBuilder.Entity<DjurArt>()
                .Property(e => e.Benämning)
                .IsUnicode(false);

            modelBuilder.Entity<DjurTyp>()
                .Property(e => e.Benämning)
                .IsUnicode(false);

            modelBuilder.Entity<Föräldrar>()
                .HasMany(e => e.Djur)
                .WithOptional(e => e.Föräldrar)
                .HasForeignKey(e => e.FöräldrarID);

            modelBuilder.Entity<MedicinTillDiagnos>()
                .Property(e => e.Benämning)
                .IsUnicode(false);

            modelBuilder.Entity<Ursprungsland>()
                .Property(e => e.Benämning)
                .IsUnicode(false);

            modelBuilder.Entity<Veterinär>()
                .Property(e => e.Namn)
                .IsUnicode(false);
        }
    }
}
