using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Models
{
    public class ScopoProgetto
    {
        [Key]
        public Guid IDScopoProgetto { get; set; }
        public String Titolo { get; set; }
        public String Descrizione { get; set; }
        public int RangeOrario { get; set; } //utilizzato dalla funzione che pesca un record a seconda dell'orario in cui ci troviamo
    }
}

    