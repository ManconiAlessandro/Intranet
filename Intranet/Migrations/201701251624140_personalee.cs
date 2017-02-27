namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personalee : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Personales");
            AddColumn("dbo.Personales", "IDPersonale", c => c.Guid(nullable: false));
            AddColumn("dbo.Personales", "NomeAddetto", c => c.String());
            AddPrimaryKey("dbo.Personales", "IDPersonale");
            DropColumn("dbo.Personales", "IDCartellaClinica");
            DropColumn("dbo.Personales", "NomePaziente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personales", "NomePaziente", c => c.String());
            AddColumn("dbo.Personales", "IDCartellaClinica", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.Personales");
            DropColumn("dbo.Personales", "NomeAddetto");
            DropColumn("dbo.Personales", "IDPersonale");
            AddPrimaryKey("dbo.Personales", "IDCartellaClinica");
        }
    }
}
