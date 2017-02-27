namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScopoProgettoModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScopoProgettoModels",
                c => new
                    {
                        IDScopoProgetto = c.Guid(nullable: false),
                        Descrizione = c.String(),
                        RangeOrario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDScopoProgetto);
            
            DropTable("dbo.TestModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TestModels",
                c => new
                    {
                        CampoTest = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CampoTest);
            
            DropTable("dbo.ScopoProgettoModels");
        }
    }
}
