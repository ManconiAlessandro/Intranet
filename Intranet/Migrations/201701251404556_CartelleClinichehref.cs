namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartelleClinichehref : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartelleCliniches", "href", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartelleCliniches", "href");
        }
    }
}
