namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartelleCliniche : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartelleCliniches",
                c => new
                    {
                        IDCartellaClinica = c.Guid(nullable: false),
                        NomePaziente = c.String(),
                        Descrizione = c.String(),
                    })
                .PrimaryKey(t => t.IDCartellaClinica);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CartelleCliniches");
        }
    }
}
