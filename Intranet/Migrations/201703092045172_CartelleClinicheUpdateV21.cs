namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartelleClinicheUpdateV21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartelleCliniches", "NumeroCartellaClinica", c => c.String());
            DropColumn("dbo.CartelleCliniches", "Descrizione");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartelleCliniches", "Descrizione", c => c.String());
            DropColumn("dbo.CartelleCliniches", "NumeroCartellaClinica");
        }
    }
}
