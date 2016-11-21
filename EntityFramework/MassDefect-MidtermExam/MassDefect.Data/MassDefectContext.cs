namespace MassDefect.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MassDefectContext : DbContext
    {
        public MassDefectContext()
            : base("name=MassDefectContext")
        {
            //Database.CreateIfNotExists();
            Database.SetInitializer<MassDefectContext>(new CreateDatabaseIfNotExists<MassDefectContext>());
        }

        public virtual IDbSet<SolarSystem> SolarSystems { get; set; }
        public virtual IDbSet<Star> Stars { get; set; }
        public virtual IDbSet<Planet> Planets { get; set; }
        public virtual IDbSet<Person> Persons { get; set; }
        public virtual IDbSet<Anomaly> Anomalies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anomaly>()
                .HasMany<Person>(anomaly => anomaly.Victims)
                .WithMany(person => person.Anomalies)
                .Map(entity =>
                {
                    entity.ToTable("AnomalyVictims");
                    entity.MapLeftKey("AnomalyId");
                    entity.MapRightKey("PersonId");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}