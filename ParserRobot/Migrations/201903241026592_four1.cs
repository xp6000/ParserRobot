namespace ParserRobot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class four1 : DbMigration
    {
        public override void Up()
        {
         //   DropColumn("dbo.SiteLinks", "check");
          //  DropColumn("dbo.SiteLinks", "Discriminator");
        }
        
        public override void Down()
        {
          //  AddColumn("dbo.SiteLinks", "Discriminator", c => c.String(nullable: false, maxLength: 128));
          //  AddColumn("dbo.SiteLinks", "check", c => c.Boolean());
        }
    }
}
