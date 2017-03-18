using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Models
{
    public class Personale
    {
        [Key]
        public Guid IDPersonale { get; set; }
        [DisplayName("Numero di matricola")]
        public String NumeroMatricola { get; set; }
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
        [DisplayName("Cittadinanza")]
        public String Cittadinanza { get; set; }
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
        [DisplayName("Stato Carichi Pendenti")]
        public String CarichiPendentiEsito { get; set; }
        [DisplayName("Reati a carico")]
        public String CarichiPendentiDescrizione { get; set; }
    }
}

    