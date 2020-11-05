namespace Lawyer_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NationalID = c.String(),
                        Phone = c.String(),
                        tawkelNumber = c.String(),
                        AuthorizationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lawsuits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LawsuitNumber = c.String(),
                        year = c.String(),
                        date = c.DateTime(nullable: false),
                        LawsuitType = c.String(),
                        LawsuitDetails = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        img = c.Binary(),
                        lawsuit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Lawsuits", t => t.lawsuit_Id)
                .Index(t => t.lawsuit_Id);
            
            CreateTable(
                "dbo.IDs",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        DocumentId = c.Int(nullable: false),
                        LawsuiteId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientId, t.DocumentId, t.LawsuiteId })
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.DocumentId, cascadeDelete: true)
                .ForeignKey("dbo.Lawsuits", t => t.LawsuiteId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.DocumentId)
                .Index(t => t.LawsuiteId);
            
            CreateTable(
                "dbo.Opponents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Notes = c.String(),
                        LawsuitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lawsuits", t => t.LawsuitId, cascadeDelete: true)
                .Index(t => t.LawsuitId);
            
            CreateTable(
                "dbo.sessions",
                c => new
                    {
                        LawsuiteId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        dession = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LawsuiteId)
                .ForeignKey("dbo.Lawsuits", t => t.LawsuiteId)
                .Index(t => t.LawsuiteId);
            
            CreateTable(
                "dbo.LawsuitClients",
                c => new
                    {
                        Lawsuit_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Lawsuit_Id, t.Client_Id })
                .ForeignKey("dbo.Lawsuits", t => t.Lawsuit_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Lawsuit_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sessions", "LawsuiteId", "dbo.Lawsuits");
            DropForeignKey("dbo.Opponents", "LawsuitId", "dbo.Lawsuits");
            DropForeignKey("dbo.IDs", "LawsuiteId", "dbo.Lawsuits");
            DropForeignKey("dbo.IDs", "DocumentId", "dbo.Documents");
            DropForeignKey("dbo.IDs", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Documents", "lawsuit_Id", "dbo.Lawsuits");
            DropForeignKey("dbo.LawsuitClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.LawsuitClients", "Lawsuit_Id", "dbo.Lawsuits");
            DropIndex("dbo.LawsuitClients", new[] { "Client_Id" });
            DropIndex("dbo.LawsuitClients", new[] { "Lawsuit_Id" });
            DropIndex("dbo.sessions", new[] { "LawsuiteId" });
            DropIndex("dbo.Opponents", new[] { "LawsuitId" });
            DropIndex("dbo.IDs", new[] { "LawsuiteId" });
            DropIndex("dbo.IDs", new[] { "DocumentId" });
            DropIndex("dbo.IDs", new[] { "ClientId" });
            DropIndex("dbo.Documents", new[] { "lawsuit_Id" });
            DropTable("dbo.LawsuitClients");
            DropTable("dbo.sessions");
            DropTable("dbo.Opponents");
            DropTable("dbo.IDs");
            DropTable("dbo.Documents");
            DropTable("dbo.Lawsuits");
            DropTable("dbo.Clients");
        }
    }
}
