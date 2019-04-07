namespace ParserRobot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiteLinkMnogoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        Title = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteLinkRashods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        Title = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteLinkUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        Title = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteLinkZipZips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        Title = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiteLinkZipZips");
            DropTable("dbo.SiteLinkUnits");
            DropTable("dbo.SiteLinkRashods");
            DropTable("dbo.SiteLinkMnogoes");
        }
    }
}
