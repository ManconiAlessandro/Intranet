namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonaleV4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personales", "CarichiPendentiEsito", c => c.String());
            AddColumn("dbo.Personales", "CarichiPendentiDescrizione", c => c.String());
            DropColumn("dbo.Personales", "TipoDiNascita");
            DropColumn("dbo.Personales", "ManoDominante");
            DropColumn("dbo.Personales", "TipoDiAllattamento");
            DropColumn("dbo.Personales", "Allergie");
            DropColumn("dbo.Personales", "AllergieDescrizione");
            DropColumn("dbo.Personales", "Convulsioni");
            DropColumn("dbo.Personales", "Vertigini");
            DropColumn("dbo.Personales", "Nevralgie");
            DropColumn("dbo.Personales", "Insonnia");
            DropColumn("dbo.Personales", "NevrosismoDepressione");
            DropColumn("dbo.Personales", "VomitoNeurologico");
            DropColumn("dbo.Personales", "FamiliariPatologieFisiche");
            DropColumn("dbo.Personales", "FamiliariPatologiePsicologiche");
            DropColumn("dbo.Personales", "FamiliariPatologiePsichiatriche");
            DropColumn("dbo.Personales", "PatologieFisicheGravi");
            DropColumn("dbo.Personales", "PatologiePsicologiche");
            DropColumn("dbo.Personales", "PatologiePsichiatriche");
            DropColumn("dbo.Personales", "StoriaRemotaEPresente");
            DropColumn("dbo.Personales", "Diagnosi");
            DropColumn("dbo.Personales", "TendenzaAllaViolenza");
            DropColumn("dbo.Personales", "LivelloConformita");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personales", "LivelloConformita", c => c.String());
            AddColumn("dbo.Personales", "TendenzaAllaViolenza", c => c.String());
            AddColumn("dbo.Personales", "Diagnosi", c => c.String());
            AddColumn("dbo.Personales", "StoriaRemotaEPresente", c => c.String());
            AddColumn("dbo.Personales", "PatologiePsichiatriche", c => c.String());
            AddColumn("dbo.Personales", "PatologiePsicologiche", c => c.String());
            AddColumn("dbo.Personales", "PatologieFisicheGravi", c => c.String());
            AddColumn("dbo.Personales", "FamiliariPatologiePsichiatriche", c => c.String());
            AddColumn("dbo.Personales", "FamiliariPatologiePsicologiche", c => c.String());
            AddColumn("dbo.Personales", "FamiliariPatologieFisiche", c => c.String());
            AddColumn("dbo.Personales", "VomitoNeurologico", c => c.String());
            AddColumn("dbo.Personales", "NevrosismoDepressione", c => c.String());
            AddColumn("dbo.Personales", "Insonnia", c => c.String());
            AddColumn("dbo.Personales", "Nevralgie", c => c.String());
            AddColumn("dbo.Personales", "Vertigini", c => c.String());
            AddColumn("dbo.Personales", "Convulsioni", c => c.String());
            AddColumn("dbo.Personales", "AllergieDescrizione", c => c.String());
            AddColumn("dbo.Personales", "Allergie", c => c.String());
            AddColumn("dbo.Personales", "TipoDiAllattamento", c => c.String());
            AddColumn("dbo.Personales", "ManoDominante", c => c.String());
            AddColumn("dbo.Personales", "TipoDiNascita", c => c.String());
            DropColumn("dbo.Personales", "CarichiPendentiDescrizione");
            DropColumn("dbo.Personales", "CarichiPendentiEsito");
        }
    }
}
