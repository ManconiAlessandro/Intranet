using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Models
{
    public class CartelleCliniche
    {
        [Key]
        public Guid IDCartellaClinica { get; set; }
        [DisplayName("N° Cartella")]
        public String NumeroCartellaClinica { get; set; }
        public String Nome { get; set; }
        public String Cognome { get; set; }
        public String NomeCompleto => $"{Nome} {Cognome}".Trim();
        public String href { get; set; } //utilizzato per selezionare il campo dal menù
        [DisplayName("Luogo di Nascita")]
        public String LuogoDiNascita { get; set; }
        [DisplayName("Data di Nascita")]
        public String DataDiNascita { get; set; }
        [DisplayName("Età")]
        public String Eta { get; set; }
        public String Sesso { get; set; }
        [DisplayName("Codice Fiscale")]
        public String CodiceFiscale { get; set; }
        [DisplayName("Stato Civile")]
        public String StatoCivile { get; set; }
        [DisplayName("Nome Del Coniuge")]
        public String NomeDelConiuge { get; set; }
        [DisplayName("Professione Attuale")]
        public String ProfessioneAttuale { get; set; }
        public String Residenza { get; set; }
        public String Telefono { get; set; }
        [DisplayName("Invitato Da")]
        public String InvitatoDa { get; set; }
        public String Peso { get; set; }
        public String Altezza { get; set; }
        [DisplayName("Tipo Di Nascita")]
        public String TipoDiNascita { get; set; }
        [DisplayName("Mano Dominante")]
        public String ManoDominante { get; set; }
        [DisplayName("Tipo Di Allattamento")]
        public String TipoDiAllattamento { get; set; }
        public String Allergie { get; set; }
        public String Convulsioni { get; set; }
        public String Vertigini { get; set; }
        public String Insonnia { get; set; }
        [DisplayName("Nevrosismo Depressione")]
        public String NevrosismoDepressione { get; set; }
        [DisplayName("Vomito Neurologico")]
        public String VomitoNeurologico { get; set; }
        [DisplayName("Familiari con Patologie Fisiche (specificare quali)")]
        public String FamiliariPatologieFisiche { get; set; }
        [DisplayName("Familiari con Patologie Psicologiche (senza assunzione di farmaci)")]
        public String FamiliariPatologiePsicologiche { get; set; }
        [DisplayName("Familiari con Patologie Psichiatriche (con assunzione di farmaci)")]
        public String FamiliariPatologiePsichiatriche { get; set; }
        [DisplayName("Patologie Fisiche Gravi (specificare patologia e cura)")]
        public String PatologieFisicheGravi { get; set; }
        [DisplayName("Patologie Psicologiche (specificare patologia e cura)")]
        public String PatologiePsicologiche { get; set; }
        [DisplayName("Patologie Psichiatriche (specificare patologia e cura)")]
        public String PatologiePsichiatriche { get; set; }
        [DisplayName("Tendenza Alla Violenza (Secondo Scala D639)")]
        public String TendenzaAllaViolenza { get; set; }
        [DisplayName("Livello Conformita (Secondo scala Ditter)")]
        public String LivelloConformita { get; set; }
    }
}

    