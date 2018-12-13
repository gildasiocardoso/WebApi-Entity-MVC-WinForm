namespace WebApiEFModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PortfolioModel : DbContext
    {
        public PortfolioModel()
            : base("name=MYPORTOFOLIO")
        {
        }
        public virtual DbSet<BRAND> BRAND { get; set; }
        public virtual DbSet<KIND_OF_PACKING> KIND_OF_PACKING { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KIND_OF_PACKING>()
                .Property(e => e.HEIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KIND_OF_PACKING>()
                .Property(e => e.WIDTH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KIND_OF_PACKING>()
                .Property(e => e.DEPTH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KIND_OF_PACKING>()
                .Property(e => e.WEIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.DATE_OF_REGISTER)
                .HasPrecision(3);

            modelBuilder.Entity<SUPPLIER>()
                .HasMany(e => e.BRAND)
                .WithRequired(e => e.SUPPLIER)
                .WillCascadeOnDelete(false);
        }
    }
}
