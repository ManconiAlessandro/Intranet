namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScopoProgetto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ScopoProgettoModels", newName: "ScopoProgettoes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ScopoProgettoes", newName: "ScopoProgettoModels");
        }
    }
}
