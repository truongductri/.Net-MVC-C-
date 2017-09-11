namespace ApartmentManage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        StudentId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        NumOfMonth = c.Int(nullable: false),
                        MoneyAmount = c.Long(nullable: false),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(),
                        Image = c.String(),
                        No = c.String(),
                        Capacity = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                        Price = c.Long(nullable: false),
                        Number = c.Int(nullable: false),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeRooms", t => t.Type)
                .Index(t => t.Type);
            
            CreateTable(
                "dbo.TypeRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Age = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        NoIdentity = c.Int(nullable: false),
                        Sex = c.Int(),
                        Phone = c.Int(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contracts", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Contracts", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Type", "dbo.TypeRooms");
            DropIndex("dbo.Rooms", new[] { "Type" });
            DropIndex("dbo.Contracts", new[] { "RoomId" });
            DropIndex("dbo.Contracts", new[] { "StudentId" });
            DropTable("dbo.Students");
            DropTable("dbo.TypeRooms");
            DropTable("dbo.Rooms");
            DropTable("dbo.Contracts");
        }
    }
}
