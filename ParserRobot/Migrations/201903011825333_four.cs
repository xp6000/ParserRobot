namespace ParserRobot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class four : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SiteLinks", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SiteLinks", new[] { "Id" });
        }
    }
}
