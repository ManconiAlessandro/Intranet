namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScopoProgettoTitolo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScopoProgettoes", "Titolo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScopoProgettoes", "Titolo");
        }
    }
}
