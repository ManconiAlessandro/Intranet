namespace Intranet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartelleClinicheUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartelleCliniches", "Nome", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Cognome", c => c.String());
            AddColumn("dbo.CartelleCliniches", "LuogoDiNascita", c => c.String());
            AddColumn("dbo.CartelleCliniches", "DataDiNascita", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Eta", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Sesso", c => c.String());
            AddColumn("dbo.CartelleCliniches", "CodiceFiscale", c => c.String());
            AddColumn("dbo.CartelleCliniches", "StatoCivile", c => c.String());
            AddColumn("dbo.CartelleCliniches", "NomeDelConiuge", c => c.String());
            AddColumn("dbo.CartelleCliniches", "ProfessioneAttuale", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Residenza", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Telefono", c => c.String());
            AddColumn("dbo.CartelleCliniches", "InvitatoDa", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Peso", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Altezza", c => c.String());
            AddColumn("dbo.CartelleCliniches", "TipoDiNascita", c => c.String());
            AddColumn("dbo.CartelleCliniches", "ManoDominante", c => c.String());
            AddColumn("dbo.CartelleCliniches", "TipoDiAllattamento", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Allergie", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Convulsioni", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Vertigini", c => c.String());
            AddColumn("dbo.CartelleCliniches", "Insonnia", c => c.String());
            AddColumn("dbo.CartelleCliniches", "NevrosismoDepressione", c => c.String());
            AddColumn("dbo.CartelleCliniches", "VomitoNeurologico", c => c.String());
            AddColumn("dbo.CartelleCliniches", "FamiliariPatologieFisiche", c => c.String());
            AddColumn("dbo.CartelleCliniches", "FamiliariPatologiePsicologiche", c => c.String());
            AddColumn("dbo.CartelleCliniches", "FamiliariPatologiePsichiatriche", c => c.String());
            AddColumn("dbo.CartelleCliniches", "PatologieFisicheGravi", c => c.String());
            AddColumn("dbo.CartelleCliniches", "PatologiePsicologiche", c => c.String());
            AddColumn("dbo.CartelleCliniches", "PatologiePsichiatriche", c => c.String());
            AddColumn("dbo.CartelleCliniches", "TendenzaAllaViolenza", c => c.String());
            AddColumn("dbo.CartelleCliniches", "LivelloConformita", c => c.String());
            DropColumn("dbo.CartelleCliniches", "NomePaziente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartelleCliniches", "NomePaziente", c => c.String());
            DropColumn("dbo.CartelleCliniches", "LivelloConformita");
            DropColumn("dbo.CartelleCliniches", "TendenzaAllaViolenza");
            DropColumn("dbo.CartelleCliniches", "PatologiePsichiatriche");
            DropColumn("dbo.CartelleCliniches", "PatologiePsicologiche");
            DropColumn("dbo.CartelleCliniches", "PatologieFisicheGravi");
            DropColumn("dbo.CartelleCliniches", "FamiliariPatologiePsichiatriche");
            DropColumn("dbo.CartelleCliniches", "FamiliariPatologiePsicologiche");
            DropColumn("dbo.CartelleCliniches", "FamiliariPatologieFisiche");
            DropColumn("dbo.CartelleCliniches", "VomitoNeurologico");
            DropColumn("dbo.CartelleCliniches", "NevrosismoDepressione");
            DropColumn("dbo.CartelleCliniches", "Insonnia");
            DropColumn("dbo.CartelleCliniches", "Vertigini");
            DropColumn("dbo.CartelleCliniches", "Convulsioni");
            DropColumn("dbo.CartelleCliniches", "Allergie");
            DropColumn("dbo.CartelleCliniches", "TipoDiAllattamento");
            DropColumn("dbo.CartelleCliniches", "ManoDominante");
            DropColumn("dbo.CartelleCliniches", "TipoDiNascita");
            DropColumn("dbo.CartelleCliniches", "Altezza");
            DropColumn("dbo.CartelleCliniches", "Peso");
            DropColumn("dbo.CartelleCliniches", "InvitatoDa");
            DropColumn("dbo.CartelleCliniches", "Telefono");
            DropColumn("dbo.CartelleCliniches", "Residenza");
            DropColumn("dbo.CartelleCliniches", "ProfessioneAttuale");
            DropColumn("dbo.CartelleCliniches", "NomeDelConiuge");
            DropColumn("dbo.CartelleCliniches", "StatoCivile");
            DropColumn("dbo.CartelleCliniches", "CodiceFiscale");
            DropColumn("dbo.CartelleCliniches", "Sesso");
            DropColumn("dbo.CartelleCliniches", "Eta");
            DropColumn("dbo.CartelleCliniches", "DataDiNascita");
            DropColumn("dbo.CartelleCliniches", "LuogoDiNascita");
            DropColumn("dbo.CartelleCliniches", "Cognome");
            DropColumn("dbo.CartelleCliniches", "Nome");
        }
    }
}
