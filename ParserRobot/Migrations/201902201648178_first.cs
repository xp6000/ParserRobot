namespace ParserRobot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiteLinks",
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
            DropTable("dbo.SiteLinks");
        }
    }
}
