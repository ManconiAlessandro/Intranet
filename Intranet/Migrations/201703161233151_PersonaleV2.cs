namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonaleV2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personales", "Nome", c => c.String());
            AddColumn("dbo.Personales", "Cognome", c => c.String());
            AddColumn("dbo.Personales", "LuogoDiNascita", c => c.String());
            AddColumn("dbo.Personales", "DataDiNascita", c => c.String());
            AddColumn("dbo.Personales", "Eta", c => c.String());
            AddColumn("dbo.Personales", "Sesso", c => c.String());
            AddColumn("dbo.Personales", "CodiceFiscale", c => c.String());
            AddColumn("dbo.Personales", "Cittadinanza", c => c.String());
            AddColumn("dbo.Personales", "StatoCivile", c => c.String());
            AddColumn("dbo.Personales", "NomeDelConiuge", c => c.String());
            AddColumn("dbo.Personales", "ProfessioneAttuale", c => c.String());
            AddColumn("dbo.Personales", "Residenza", c => c.String());
            AddColumn("dbo.Personales", "Telefono", c => c.String());
            AddColumn("dbo.Personales", "InvitatoDa", c => c.String());
            AddColumn("dbo.Personales", "Peso", c => c.String());
            AddColumn("dbo.Personales", "Altezza", c => c.String());
            AddColumn("dbo.Personales", "TipoDiNascita", c => c.String());
            AddColumn("dbo.Personales", "ManoDominante", c => c.String());
            AddColumn("dbo.Personales", "TipoDiAllattamento", c => c.String());
            AddColumn("dbo.Personales", "Allergie", c => c.String());
            AddColumn("dbo.Personales", "AllergieDescrizione", c => c.String());
            AddColumn("dbo.Personales", "Convulsioni", c => c.String());
            AddColumn("dbo.Personales", "Vertigini", c => c.String());
            AddColumn("dbo.Personales", "Nevralgie", c => c.String());
            AddColumn("dbo.Personales", "Insonnia", c => c.String());
            AddColumn("dbo.Personales", "NevrosismoDepressione", c => c.String());
            AddColumn("dbo.Personales", "VomitoNeurologico", c => c.String());
            AddColumn("dbo.Personales", "FamiliariPatologieFisiche", c => c.String());
            AddColumn("dbo.Personales", "FamiliariPatologiePsicologiche", c => c.String());
            AddColumn("dbo.Personales", "FamiliariPatologiePsichiatriche", c => c.String());
            AddColumn("dbo.Personales", "PatologieFisicheGravi", c => c.String());
            AddColumn("dbo.Personales", "PatologiePsicologiche", c => c.String());
            AddColumn("dbo.Personales", "PatologiePsichiatriche", c => c.String());
            AddColumn("dbo.Personales", "StoriaRemotaEPresente", c => c.String());
            AddColumn("dbo.Personales", "Diagnosi", c => c.String());
            AddColumn("dbo.Personales", "TendenzaAllaViolenza", c => c.String());
            AddColumn("dbo.Personales", "LivelloConformita", c => c.String());
            DropColumn("dbo.Personales", "NomeAddetto");
            DropColumn("dbo.Personales", "Descrizione");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personales", "Descrizione", c => c.String());
            AddColumn("dbo.Personales", "NomeAddetto", c => c.String());
            DropColumn("dbo.Personales", "LivelloConformita");
            DropColumn("dbo.Personales", "TendenzaAllaViolenza");
            DropColumn("dbo.Personales", "Diagnosi");
            DropColumn("dbo.Personales", "StoriaRemotaEPresente");
            DropColumn("dbo.Personales", "PatologiePsichiatriche");
            DropColumn("dbo.Personales", "PatologiePsicologiche");
            DropColumn("dbo.Personales", "PatologieFisicheGravi");
            DropColumn("dbo.Personales", "FamiliariPatologiePsichiatriche");
            DropColumn("dbo.Personales", "FamiliariPatologiePsicologiche");
            DropColumn("dbo.Personales", "FamiliariPatologieFisiche");
            DropColumn("dbo.Personales", "VomitoNeurologico");
            DropColumn("dbo.Personales", "NevrosismoDepressione");
            DropColumn("dbo.Personales", "Insonnia");
            DropColumn("dbo.Personales", "Nevralgie");
            DropColumn("dbo.Personales", "Vertigini");
            DropColumn("dbo.Personales", "Convulsioni");
            DropColumn("dbo.Personales", "AllergieDescrizione");
            DropColumn("dbo.Personales", "Allergie");
            DropColumn("dbo.Personales", "TipoDiAllattamento");
            DropColumn("dbo.Personales", "ManoDominante");
            DropColumn("dbo.Personales", "TipoDiNascita");
            DropColumn("dbo.Personales", "Altezza");
            DropColumn("dbo.Personales", "Peso");
            DropColumn("dbo.Personales", "InvitatoDa");
            DropColumn("dbo.Personales", "Telefono");
            DropColumn("dbo.Personales", "Residenza");
            DropColumn("dbo.Personales", "ProfessioneAttuale");
            DropColumn("dbo.Personales", "NomeDelConiuge");
            DropColumn("dbo.Personales", "StatoCivile");
            DropColumn("dbo.Personales", "Cittadinanza");
            DropColumn("dbo.Personales", "CodiceFiscale");
            DropColumn("dbo.Personales", "Sesso");
            DropColumn("dbo.Personales", "Eta");
            DropColumn("dbo.Personales", "DataDiNascita");
            DropColumn("dbo.Personales", "LuogoDiNascita");
            DropColumn("dbo.Personales", "Cognome");
            DropColumn("dbo.Personales", "Nome");
        }
    }
}
