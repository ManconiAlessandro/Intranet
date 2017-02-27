namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personales",
                c => new
                    {
                        IDCartellaClinica = c.Guid(nullable: false),
                        NomePaziente = c.String(),
                        Descrizione = c.String(),
                        href = c.String(),
                    })
                .PrimaryKey(t => t.IDCartellaClinica);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personales");
        }
    }
}
