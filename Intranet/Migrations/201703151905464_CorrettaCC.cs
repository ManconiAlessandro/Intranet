namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrettaCC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartelleCliniches", "Cittadinanza", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Nevralgie", c => c.String());
            AddColumn("dbo.CartelleCliniches", "StoriaRemotaEPresente", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Diagnosi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartelleCliniches", "Diagnosi");
            DropColumn("dbo.CartelleCliniches", "StoriaRemotaEPresente");
            DropColumn("dbo.CartelleCliniches", "Nevralgie");
            DropColumn("dbo.CartelleCliniches", "Cittadinanza");
        }
    }
}
