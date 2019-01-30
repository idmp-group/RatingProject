namespace DataLayer.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class EF : DbContext
    {
        // Your context has been configured to use a 'EF' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataLayer.Model.EF' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EF' 
        // connection string in the application configuration file.
        public EF()
            : base("name=EF1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //one to one relations
            modelBuilder.Entity<Product>()
                .HasOptional(s => s.Image) // Mark Address property optional in Student entity
                .WithRequired(g => g.Product); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
            modelBuilder.Entity<Store>()
                .HasOptional(s => s.Image)
                .WithRequired(g => g.Store);
            modelBuilder.Entity<Service>()
                .HasOptional(s => s.Image)
                .WithRequired(g => g.Service);

            //
            //modelBuilder.Entity<Comment>()
            //    .HasRequired<Store>(c => c.Store)
            //    .WithMany()
            //    .HasForeignKey(c => c.StoreCode)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Service>()
            //    .HasRequired(s => s.Store)
            //    .WithMany()
            //    .HasForeignKey(c => c.StoreCode)
            //    .WillCascadeOnDelete(false);
            //
            //modelBuilder.Entity<Comment>()
            //    .HasRequired(c => c.Store)
            //    .WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Service>()
            //    .HasRequired(s => s.Store)
            //    .WithMany().WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}