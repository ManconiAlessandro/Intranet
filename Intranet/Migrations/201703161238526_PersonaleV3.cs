namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonaleV3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personales", "NumeroMatricola", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personales", "NumeroMatricola");
        }
    }
}
