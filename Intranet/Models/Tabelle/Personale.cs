using System;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Models
{
    public class Personale
    {
        [Key]
        public Guid IDPersonale { get; set; }

        public String NomeAddetto { get; set; }

        public String Descrizione { get; set; }

        public String href { get; set; } //utilizzato per selezionare il campo dal menù
    }
}

    