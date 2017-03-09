namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ScopoProgettoes", newName: "Progettoes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Progettoes", newName: "ScopoProgettoes");
        }
    }
}
