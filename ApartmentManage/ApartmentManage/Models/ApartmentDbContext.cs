namespace ApartmentManage.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApartmentDbContext : DbContext
    {
        // Your context has been configured to use a 'ApartmentDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Model.Models.ApartmentDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ApartmentDbContext' 
        // connection string in the application configuration file.
        public ApartmentDbContext()
            : base("name=ApartmentDbContext")
        {
        }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<TypeRoom> TypeRooms { get; set; }
       

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