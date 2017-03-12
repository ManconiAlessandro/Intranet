namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AggiunteAllergieDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartelleCliniches", "AllergieDescrizione", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartelleCliniches", "AllergieDescrizione");
        }
    }
}
