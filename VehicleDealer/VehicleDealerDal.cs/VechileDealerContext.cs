namespace VehicleDealerDal.cs
{
    using VehicleDealer.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VechileDealerContext : DbContext
    {
        // Your context has been configured to use a 'VechileDealerContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'VehicleDealerDal.cs.VechileDealerContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'VechileDealerContext' 
        // connection string in the application configuration file.
        public VechileDealerContext()
            : base("name=VechileDealerContext")
        {
            Database.SetInitializer<VechileDealerContext>(new DropCreateDatabaseIfModelChanges<VechileDealerContext>());
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Modeels> Modeels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicle>()
                    .HasRequired<Dealer>(d => d.Dealer)
                    .WithMany(v => v.Vehcile)
                    .HasForeignKey(d => d.DealerId);


            modelBuilder.Entity<Brand>()
                    .HasRequired<Vehicle>(v => v.Vehicle)
                    .WithMany(b => b.Brand)
                    .HasForeignKey(v => v.VehicleId);

            modelBuilder.Entity<Modeels>()
                   .HasRequired<Brand>(b => b.Brand)
                   .WithMany(m => m.Models)
                   .HasForeignKey(b => b.BrandId);

        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}